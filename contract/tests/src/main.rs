use borsh::BorshSerialize;
use serde_json::json;

// const GAS_PRICE_IN_NEAR: f64 = 0.0001;
const NEAR_PRICE_IN_USD: f64 = 6.68;

fn gas_to_usd(gas: u64) -> f64 {
    (gas as f64) / 1e16 * NEAR_PRICE_IN_USD
}

fn tokens_to_usd(tokens: u128) -> f64 {
    (tokens as f64) / 1e24 * NEAR_PRICE_IN_USD
}

fn print_usd(result: near_workspaces::result::ExecutionFinalResult) {
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

// The logs of every receipt of a call: count and total bytes (NEAR fails a receipt past 100 logs or 16 KiB of logs).
fn print_logs(name: &str, result: &near_workspaces::result::ExecutionFinalResult) {
    result.outcomes().iter().for_each(|outcome| {
        let bytes: usize = outcome.logs.iter().map(|log| log.len()).sum();
        println!(
            "{name}: receipt logs: {} / {bytes} bytes",
            outcome.logs.len()
        );
        assert!(outcome.logs.len() <= 100 && bytes <= 16384);
    });
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
    // let contract_id = contract.id();

    // new(contract)
    let result = contract.call("new").transact().await?;
    println!("\n\nnew: {result:#?}");
    print_usd(result);

    // roll_within_bounds(contract, '')
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
        Ok(result) => {
            assert_eq!(result.json().ok(), Some(995_i32));
        }
        Err(_) => {
            panic!("Expected Some(ExecutionResult<Value>)");
        }
    }

    // roll_within_bounds_borsh(contract, '')
    let result = contract
        .call("roll_within_bounds_borsh")
        .args((|| {
            let mut args = Vec::new();
            2000_u64.serialize(&mut args).unwrap();
            vec![2u8, 2, 6, 4, 5].serialize(&mut args).unwrap();
            args
        })())
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
        Err(_) => {
            panic!("Expected Some(ExecutionResult<Value>)");
        }
    }

    // generate_random_number(contract, '')
    let result = contract
        .call("generate_random_number")
        .args_json(json!({
            "key": "key",
            "proof": "proof",
            "max": 2000,
        }))
        .gas(near_workspaces::types::Gas::from_tgas(300))
        .transact()
        .await?;
    println!("\n\ngenerate_random_number(contract, ''): {result:#?}");
    print_usd(result.clone());
    match result.into_result() {
        Ok(result) => match result.json::<u64>().ok() {
            Some(n) => {
                println!("n: {n:#?}");
            }
            None => {
                panic!("Expected Some(u64)");
            }
        },
        Err(_) => {
            panic!("Expected Some(ExecutionResult<Value>)");
        }
    }

    // contribute_seed(contract, 150 bytes): the store keeps the last 100 seed bytes (drains the excess)
    let result = contract
        .call("contribute_seed")
        .args_json(json!({ "seed": (0..150).map(|i| i as u8).collect::<Vec<u8>>() }))
        .gas(near_workspaces::types::Gas::from_tgas(300))
        .transact()
        .await?;
    println!("\n\ncontribute_seed(contract, 150 bytes): {result:#?}");
    print_usd(result.clone());
    print_logs("contribute_seed", &result);
    println!("contribute_seed: gas {}", result.total_gas_burnt.as_gas());
    assert!(result.is_success(), "contribute_seed failed");

    // contribute_seed_borsh(contract, 10 bytes)
    let result = contract
        .call("contribute_seed_borsh")
        .args((|| {
            let mut args = Vec::new();
            vec![7u8; 10].serialize(&mut args).unwrap();
            args
        })())
        .gas(near_workspaces::types::Gas::from_tgas(300))
        .transact()
        .await?;
    println!("\n\ncontribute_seed_borsh(contract, 10 bytes): {result:#?}");
    print_usd(result.clone());
    print_logs("contribute_seed_borsh", &result);
    println!(
        "contribute_seed_borsh: gas {}",
        result.total_gas_burnt.as_gas()
    );
    assert!(result.is_success(), "contribute_seed_borsh failed");

    // generate_random_number(contract, max): large bounds roll many dice per round, and a bound just past a power of 6
    // rejects about 5 of 6 rounds, so these calls trace the most; each must succeed within the log limits and return a
    // number in 1..=max. 6^24 is the largest bound: the dice sum of a larger one doesn't fit a u64 (see below).
    let maxes: [u64; 6] = [
        6u64.pow(24),
        (1 << 62) + 1,
        6u64.pow(10) + 1,
        6u64.pow(3) + 1,
        2000,
        1,
    ];
    for (i, max) in maxes.iter().enumerate() {
        let result = contract
            .call("generate_random_number")
            .args_json(json!({
                "key": format!("key{i}"),
                "proof": "proof",
                "max": max,
            }))
            .gas(near_workspaces::types::Gas::from_tgas(300))
            .transact()
            .await?;
        println!(
            "\n\ngenerate_random_number(contract, max = {max}): success {}, gas {}",
            result.is_success(),
            result.total_gas_burnt.as_gas()
        );
        print_logs(&format!("generate_random_number max = {max}"), &result);
        match result.into_result() {
            Ok(result) => match result.json::<u64>().ok() {
                Some(n) => {
                    println!("n: {n:#?}");
                    assert!(1 <= n && n <= *max, "{n} not in 1..={max}");
                }
                None => {
                    panic!("Expected Some(u64)");
                }
            },
            Err(e) => {
                panic!("generate_random_number max = {max} failed: {e:#?}");
            }
        }
    }

    // generate_random_number(contract, max > 6^24): lib.dice rejects the bound (its dice sum would overflow a u64), so
    // the call fails with that message instead of an arithmetic overflow or a wrong dice count.
    for max in [6u64.pow(24) + 1, u64::MAX] {
        let result = contract
            .call("generate_random_number")
            .args_json(json!({
                "key": "key",
                "proof": "proof",
                "max": max,
            }))
            .gas(near_workspaces::types::Gas::from_tgas(300))
            .transact()
            .await?;
        println!(
            "\n\ngenerate_random_number(contract, max = {max}): success {}, gas {}",
            result.is_success(),
            result.total_gas_burnt.as_gas()
        );
        print_logs(&format!("generate_random_number max = {max}"), &result);
        match result.into_result() {
            Ok(result) => panic!("generate_random_number max = {max} must fail: {result:#?}"),
            Err(e) => {
                let e = format!("{e:?}");
                println!("rejected: {e}");
                assert!(
                    e.contains("is above the largest supported bound 4738381338321616896"),
                    "generate_random_number max = {max}: unexpected failure {e}"
                );
            }
        }
    }

    println!("\n\ndice contract tests: all passed");
    Ok(())
}
