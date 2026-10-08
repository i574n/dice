use borsh::BorshSerialize;
use near_workspaces::result::ExecutionFinalResult;
use near_workspaces::types::Gas;
use near_workspaces::Contract;
use serde_json::json;

const NEAR_PRICE_IN_USD: f64 = 6.68;
const GAS_PER_NEAR: f64 = 1e16;
const YOCTO_PER_NEAR: f64 = 1e24;
const CALL_GAS_TGAS: u64 = 300;
const MAX_RECEIPT_LOGS: usize = 100;
const MAX_RECEIPT_LOG_BYTES: usize = 16 * 1024;
const SEED_BYTES_PAST_STORE_CAPACITY: u8 = 150;
const LARGEST_DICE_BOUND: u64 = 6u64.pow(24);
const BOUNDS_THAT_TRACE_THE_MOST: [u64; 6] = [
    LARGEST_DICE_BOUND,
    (1 << 62) + 1,
    6u64.pow(10) + 1,
    6u64.pow(3) + 1,
    2000,
    1,
];
const BOUNDS_ABOVE_THE_LARGEST: [u64; 2] = [LARGEST_DICE_BOUND + 1, u64::MAX];

fn gas_to_usd(gas: u64) -> f64 {
    (gas as f64) / GAS_PER_NEAR * NEAR_PRICE_IN_USD
}

fn tokens_to_usd(tokens: u128) -> f64 {
    (tokens as f64) / YOCTO_PER_NEAR * NEAR_PRICE_IN_USD
}

fn print_usd(result: ExecutionFinalResult) {
    println!(
        "total_gas_burnt_usd: {:#?}",
        gas_to_usd(result.total_gas_burnt.as_gas())
    );
    result.outcomes().iter().for_each(|outcome| {
        println!("outcome (success: {:#?}):", outcome.is_success());
        println!(
            "  outcome_gas_burnt_usd: {:#?}",
            gas_to_usd(outcome.gas_burnt.as_gas())
        );
        println!(
            "  outcome_tokens_burnt_usd: {:#?}",
            tokens_to_usd(outcome.tokens_burnt.as_near())
        );
    });
}

fn assert_receipts_within_log_limits(name: &str, result: &ExecutionFinalResult) {
    result.outcomes().iter().for_each(|outcome| {
        let bytes: usize = outcome.logs.iter().map(|log| log.len()).sum();
        println!(
            "{name}: receipt logs: {} / {bytes} bytes",
            outcome.logs.len()
        );
        assert!(outcome.logs.len() <= MAX_RECEIPT_LOGS && bytes <= MAX_RECEIPT_LOG_BYTES);
    });
}

fn borsh_args(write: impl FnOnce(&mut Vec<u8>)) -> Vec<u8> {
    let mut args = Vec::new();
    write(&mut args);
    args
}

async fn new(contract: &Contract) -> anyhow::Result<()> {
    let result = contract.call("new").transact().await?;
    println!("\n\nnew: {result:#?}");
    print_usd(result);
    Ok(())
}

async fn roll_within_bounds(contract: &Contract) -> anyhow::Result<()> {
    let result = contract
        .call("roll_within_bounds")
        .args_json(json!({
            "max": 2000,
            "rolls": [1_i32, 5_i32, 4_i32, 4_i32, 5_i32]
        }))
        .transact()
        .await?;
    println!("\n\nroll_within_bounds(contract, ''): {result:#?}");
    print_usd(result.clone());
    match result.into_result() {
        Ok(result) => assert_eq!(result.json().ok(), Some(995_i32)),
        Err(_) => panic!("Expected Some(ExecutionResult<Value>)"),
    }
    Ok(())
}

async fn roll_within_bounds_borsh(contract: &Contract) -> anyhow::Result<()> {
    let result = contract
        .call("roll_within_bounds_borsh")
        .args(borsh_args(|args| {
            2000_u64.serialize(args).unwrap();
            vec![2u8, 2, 6, 4, 5].serialize(args).unwrap();
        }))
        .transact()
        .await?;
    println!("\n\nroll_within_bounds_borsh(contract, ''): {result:#?}");
    print_usd(result.clone());
    match result.into_result() {
        Ok(result) => {
            let n = result.borsh::<Option<u64>>().ok();
            println!("n: {n:#?}");
            assert_eq!(n, Some(Some(1715)));
        }
        Err(_) => panic!("Expected Some(ExecutionResult<Value>)"),
    }
    Ok(())
}

async fn generate_random_number(contract: &Contract, key: &str, max: u64) -> anyhow::Result<ExecutionFinalResult> {
    Ok(contract
        .call("generate_random_number")
        .args_json(json!({
            "key": key,
            "proof": "proof",
            "max": max,
        }))
        .gas(Gas::from_tgas(CALL_GAS_TGAS))
        .transact()
        .await?)
}

async fn generate_random_number_returns_a_number(contract: &Contract) -> anyhow::Result<()> {
    let result = generate_random_number(contract, "key", 2000).await?;
    println!("\n\ngenerate_random_number(contract, ''): {result:#?}");
    print_usd(result.clone());
    match result.into_result() {
        Ok(result) => match result.json::<u64>().ok() {
            Some(n) => println!("n: {n:#?}"),
            None => panic!("Expected Some(u64)"),
        },
        Err(_) => panic!("Expected Some(ExecutionResult<Value>)"),
    }
    Ok(())
}

async fn contribute_seed_past_store_capacity(contract: &Contract) -> anyhow::Result<()> {
    let result = contract
        .call("contribute_seed")
        .args_json(json!({ "seed": (0..SEED_BYTES_PAST_STORE_CAPACITY).collect::<Vec<u8>>() }))
        .gas(Gas::from_tgas(CALL_GAS_TGAS))
        .transact()
        .await?;
    println!("\n\ncontribute_seed(contract, {SEED_BYTES_PAST_STORE_CAPACITY} bytes): {result:#?}");
    print_usd(result.clone());
    assert_receipts_within_log_limits("contribute_seed", &result);
    println!("contribute_seed: gas {}", result.total_gas_burnt.as_gas());
    assert!(result.is_success(), "contribute_seed failed");
    Ok(())
}

async fn contribute_seed_borsh(contract: &Contract) -> anyhow::Result<()> {
    let result = contract
        .call("contribute_seed_borsh")
        .args(borsh_args(|args| vec![7u8; 10].serialize(args).unwrap()))
        .gas(Gas::from_tgas(CALL_GAS_TGAS))
        .transact()
        .await?;
    println!("\n\ncontribute_seed_borsh(contract, 10 bytes): {result:#?}");
    print_usd(result.clone());
    assert_receipts_within_log_limits("contribute_seed_borsh", &result);
    println!(
        "contribute_seed_borsh: gas {}",
        result.total_gas_burnt.as_gas()
    );
    assert!(result.is_success(), "contribute_seed_borsh failed");
    Ok(())
}

async fn generate_random_number_within_bounds_that_trace_the_most(contract: &Contract) -> anyhow::Result<()> {
    for (i, max) in BOUNDS_THAT_TRACE_THE_MOST.iter().enumerate() {
        let result = generate_random_number(contract, &format!("key{i}"), *max).await?;
        println!(
            "\n\ngenerate_random_number(contract, max = {max}): success {}, gas {}",
            result.is_success(),
            result.total_gas_burnt.as_gas()
        );
        assert_receipts_within_log_limits(&format!("generate_random_number max = {max}"), &result);
        match result.into_result() {
            Ok(result) => match result.json::<u64>().ok() {
                Some(n) => {
                    println!("n: {n:#?}");
                    assert!(1 <= n && n <= *max, "{n} not in 1..={max}");
                }
                None => panic!("Expected Some(u64)"),
            },
            Err(e) => panic!("generate_random_number max = {max} failed: {e:#?}"),
        }
    }
    Ok(())
}

async fn generate_random_number_rejects_bounds_above_the_largest(contract: &Contract) -> anyhow::Result<()> {
    let expected = format!("is above the largest supported bound {LARGEST_DICE_BOUND}");
    for max in BOUNDS_ABOVE_THE_LARGEST {
        let result = generate_random_number(contract, "key", max).await?;
        println!(
            "\n\ngenerate_random_number(contract, max = {max}): success {}, gas {}",
            result.is_success(),
            result.total_gas_burnt.as_gas()
        );
        assert_receipts_within_log_limits(&format!("generate_random_number max = {max}"), &result);
        match result.into_result() {
            Ok(result) => panic!("generate_random_number max = {max} must fail: {result:#?}"),
            Err(e) => {
                let e = format!("{e:?}");
                println!("rejected: {e}");
                assert!(
                    e.contains(&expected),
                    "generate_random_number max = {max}: unexpected failure {e}"
                );
            }
        }
    }
    Ok(())
}

#[tokio::main]
async fn main() -> anyhow::Result<()> {
    let contract_path = std::env::var("DICE_WASM").unwrap_or_else(|_| {
        std::path::Path::new(env!("CARGO_MANIFEST_DIR"))
            .join("../dist/dice.wasm")
            .display()
            .to_string()
    });
    println!("contract: {contract_path}");

    let worker = near_workspaces::sandbox().await?;
    let wasm = std::fs::read(contract_path)?;
    let contract = worker.dev_deploy(&wasm).await?;

    new(&contract).await?;
    roll_within_bounds(&contract).await?;
    roll_within_bounds_borsh(&contract).await?;
    generate_random_number_returns_a_number(&contract).await?;
    contribute_seed_past_store_capacity(&contract).await?;
    contribute_seed_borsh(&contract).await?;
    generate_random_number_within_bounds_that_trace_the_most(&contract).await?;
    generate_random_number_rejects_bounds_above_the_largest(&contract).await?;

    println!("\n\ndice contract tests: all passed");
    Ok(())
}
