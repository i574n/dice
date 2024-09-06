#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
mod module_491a246d {
    pub mod Dice_contract {
        use super::*;
        use fable_library_rust::Native_::defaultOf;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::String_::string;
        pub fn closure0(unitVar: (), unitVar_1: ()) {} //;
        pub struct Util {} //;
        impl Util {
            //;
            fn stream_u8_to_list(
                //;
                s: fable_library_rust::Native_::LrcPtr<dice_contract_lib::Dice::UH0>, //;
            ) -> dice_contract_lib::Dice::UH1 {
                //;
                match s.as_ref() {
                    //;
                    dice_contract_lib::Dice::UH0::UH0_0(n, f) => {
                        //;
                        dice_contract_lib::Dice::UH1::UH1_1(*n, Self::stream_u8_to_list(f()).into())
                        //;
                    } //;
                    dice_contract_lib::Dice::UH0::UH0_1 => dice_contract_lib::Dice::UH1::UH1_0, //;
                } //;
            } //;
            fn list_u8_to_vec(
                //;
                s: fable_library_rust::Native_::LrcPtr<dice_contract_lib::Dice::UH1>, //;
            ) -> Vec<u8> {
                //;
                match s.as_ref() {
                    //;
                    dice_contract_lib::Dice::UH1::UH1_1(n, f) => {
                        //;
                        let mut v = Self::list_u8_to_vec(f.clone()); //;
                        v.insert(0, *n); //;
                        v //;
                    } //;
                    dice_contract_lib::Dice::UH1::UH1_0 => vec![], //;
                } //;
            } //;
            fn vec_u8_to_list(v: Vec<u8>) -> dice_contract_lib::Dice::UH1 {
                //;
                v.iter() //;
                    .rev() //;
                    .fold(dice_contract_lib::Dice::UH1::UH1_0, |acc, x| {
                        //;
                        dice_contract_lib::Dice::UH1::UH1_1(*x, acc.into()) //;
                    }) //;
            } //;
            fn vec_u8_to_stream(v: Vec<u8>) -> dice_contract_lib::Dice::UH0 {
                //;
                v.iter() //;
                    .rev() //;
                    .fold(dice_contract_lib::Dice::UH0::UH0_1, |acc, x| {
                        //;
                        dice_contract_lib::Dice::UH0::UH0_0(
                            //;
                            *x, //;
                            fable_library_rust::Native_::Func0::new(move || acc.clone().into()), //;
                        ) //;
                    }) //;
            } //;
        } //;
        #[derive(
            //;
            near_sdk::PanicOnDefault, //;
            borsh::BorshDeserialize,  //;
            borsh::BorshSerialize,    //;
        )] //;
        pub struct OldState {
            //;
            version: u32,                            //;
            seeds: near_sdk::store::vec::Vector<u8>, //;
        } //;
        #[near_sdk::near_bindgen] //;
        #[derive(
            //;
            near_sdk::PanicOnDefault, //;
            borsh::BorshDeserialize,  //;
            borsh::BorshSerialize,    //;
        )] //;
        pub struct State(
            //;
            /*;
            {
                let v60: */
            (u32, near_sdk::store::vec::Vector<u8>), /* =
                                                        defaultOf::<()>();
                                                     */
        );
        impl From<OldState> for State {
            //;
            fn from(old_state: OldState) -> Self {
                //;
                Self((old_state.version, old_state.seeds)) //;
            } //;
        } //;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[init] //;
            pub fn new() -> Self {
                // 1;
                {
                    let v74: bool = true; /*;
                                          let v75: */
                    () /* = defaultOf();
                    let v79: bool = true; */;
                    let v81: string = string("b\"seeds\"");
                    let v82: &[u8] = b"seeds";
                    {
                        let x: (u32, near_sdk::store::vec::Vector<u8>) =
                            (1_u32, near_sdk::store::vec::Vector::new(v82));
                        Self(x) // x
                    }
                } // 2.;
            } // 1.;
        } /* c;
          {
              let v89: bool =
                  true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy;
              let v91: bool =
                  true; */
 // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn contribute_seed(&mut self, seed: Vec<u8>) {
                //;
                {
                    let v96: &mut near_sdk::store::vec::Vector<u8> = &mut self.0 .1;
                    v96.extend(seed); //;
                    {
                        let v98: usize = 100_i32 as usize;
                        let seed_excess_len = (v96.len() as i32) - v98 as i32; //;
                        if seed_excess_len > 0 {
                            //;
                            let seed_excess: Vec<_> =
                                v96.drain(0..seed_excess_len as u32).collect(); //;
                            near_sdk::log!(
                                //;
                                "{}", //;
                                format!(
                                    //;
                                    "contribute_seed / seed_excess: {seed_excess:?}" //;
                                )  //;
                            ); //;
                        } //;
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v116: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy;
              let v118: bool =
                  true; */
 // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) {
                //;
                self.contribute_seed(seed) //;
            } //;
        } /* c;
          {
              let v126: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy;
              let v128: bool =
                  true; */
 // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            fn get_logger(
            ) -> fable_library_rust::Native_::Func1<fable_library_rust::String_::string, ()>
            {
                //;
                let count = std::rc::Rc::new(std::cell::RefCell::new(0)); //;
                let acc = std::rc::Rc::new(std::cell::RefCell::new(String::new())); //;
                let closure = {
                    //;
                    let count = std::rc::Rc::clone(&count); //;
                    let acc = std::rc::Rc::clone(&acc); //;
                    move |s: fable_library_rust::String_::string| {
                        //;
                        let mut count_ref = count.borrow_mut(); //;
                        let mut acc_ref = acc.borrow_mut(); //;
                        *count_ref += 1; //;
                        if s.len() == 0 || *count_ref % 6 == 0 {
                            //;
                            near_sdk::log!("{:?}", acc_ref.clone().drain(..acc_ref.len() - 1)); //;
                            *acc_ref = String::new(); //;
                        } //;
                        acc_ref.push_str(
                            &(s.to_string()
                                + "
"),
                        ); //;
                    } //;
                }; //;
                fable_library_rust::Native_::Func1::new(closure) //;
            } //;
        } /* c;
          {
              let v152: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 1uy;
              let v154: bool =
                  true; */
 // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 {
                //;
                {
                    let v159: &near_sdk::store::vec::Vector<u8> = &self.0 .1;
                    let seed = near_sdk::env::random_seed(); //;
                    let block_timestamp = near_sdk::env::block_timestamp(); //;
                    let signer_account_id = near_sdk::env::signer_account_id(); //;
                    let account_balance = near_sdk::env::account_balance(); //;
                    let block_height = near_sdk::env::block_height(); //;
                    let epoch_height = near_sdk::env::epoch_height(); //;
                    let entropy: Vec<u8> = vec![
                        //;
                        seed.clone(),                                          //;
                        block_timestamp.to_le_bytes().to_vec(),                //;
                        block_height.to_le_bytes().to_vec(),                   //;
                        epoch_height.to_le_bytes().to_vec(),                   //;
                        account_balance.as_yoctonear().to_le_bytes().to_vec(), //;
                        signer_account_id.as_bytes().to_vec(),                 //;
                        v159.iter().map(|x| *x).collect::<Vec<u8>>(),          //;
                        key.clone().into_bytes(),                              //;
                        proof.clone().into_bytes(),                            //;
                    ]
                    .concat(); //;
                    let hash_u8 = near_sdk::env::keccak512(&entropy); //;
                    self.contribute_seed(hash_u8.clone()); //;
                    let hash_stream = Util::vec_u8_to_stream(hash_u8.clone()); //;
                    let rolls_list =
                        Util::stream_u8_to_list(dice_contract_lib::Dice::rotate_numbers(6)(
                            //;
                            hash_stream.into(), //;
                        )); //;
                    {
                        //;
                        let rolls_list_log = Util::list_u8_to_vec(rolls_list.clone().into()); //;
                        let signer_account_id_log = signer_account_id.as_str(); //;
                        near_sdk::log!(
                            //;
                            "{}", //;
                            format!(
                                //;
                                "{}",
                                ("generate_random_number".to_owned() //;
                                                                + " / max: {max:?}" //;
                                                                + " / key: {key:?}" //;
                                                                + " / proof: {proof:?}" //;
                                                                + " / block_timestamp: {block_timestamp:?}" //;
                                                                + " / block_height: {block_height:?}" //;
                                                                + " / epoch_height: {epoch_height:?}" //;
                                                                + " / account_balance: {account_balance:?}" //;
                                                                + " / signer_account_id: {signer_account_id_log:?}" //;
                                                                + " / seed: {seed:?}" //;
                                                                + " / entropy: {entropy:?}" //;
                                                                + " / hash_u8: {hash_u8:?}" //;
                                                                + " / rolls_list: {rolls_list_log:?}") //;
                            )  //;
                        ); //;
                    } //;
                    let logger = Self::get_logger(); //;
                    let sequential_roll = dice_contract_lib::Dice::create_sequential_roller(Some(
                        //;
                        logger.clone(), //;
                    ))(rolls_list.into()); //;
                    let result = dice_contract_lib::Dice::roll_progressively(Some(logger.clone()))(
                        //;
                        sequential_roll, //;
                    )(true)(max); //;
                    logger("".into()); //;
                    result as u64 //;
                } //;
            } //;
        } /* c;
          {
              let v218: bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 7uy / n: 2uy;
              let v220: bool =
                  true; */
 // ???? / i: 5uy / i': 2uy / acc: 7uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> {
                //;
                near_sdk::log!(
                    //;
                    "{}", //;
                    format!(
                        //;
                        "roll_within_bounds / max: {max:#?} / rolls: {rolls:?}" //;
                    )  //;
                ); //;
                let rolls = Util::vec_u8_to_list(rolls); //;
                let logger = Self::get_logger(); //;
                let result = //;
                                                            dice_contract_lib::Dice::roll_within_bounds(Some(logger.clone()))(max)(rolls.into()); //;
                logger("".into()); //;
                result //;
            } //;
        } /* c;
          {
              let v239: bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 1uy;
              let v241: bool =
                  true; */
 // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[result_serializer(borsh)] //;
            pub fn roll_within_bounds_borsh(
                //;
                &self,                               //;
                #[serializer(borsh)] max: u64,       //;
                #[serializer(borsh)] rolls: Vec<u8>, //;
            ) -> Option<u64> {
                //;
                self.roll_within_bounds(max, rolls) //;
            } //;
        } /* c;
          {
              let v254: bool =
                  true; // ??? / i: 7uy / i': 1uy / acc: 10uy / n: 1uy;
              let v256: bool =
                  true; */
 // ???? / i: 7uy / i': 2uy / acc: 10uy / n: 1uy;
        fn _main() //;
        //;
        {
            let v260: bool = true;
            {
                (); // ?? / i': 1uy / n: 11uy;
                let v262: bool = true;
                {
                    (); // ?? / i': 2uy / n: 11uy;
                    let v264: bool = true;
                    {
                        (); // ?? / i': 3uy / n: 11uy;
                        let v266: bool = true;
                        {
                            (); // ?? / i': 4uy / n: 11uy;
                            let v268: bool = true;
                            {
                                (); // ?? / i': 5uy / n: 11uy;
                                let v270: bool = true;
                                {
                                    (); // ?? / i': 6uy / n: 11uy;
                                    let v272: bool = true;
                                    {
                                        (); // ?? / i': 7uy / n: 11uy;
                                        let v274: bool = true;
                                        {
                                            (); // ?? / i': 8uy / n: 11uy;
                                            let v276: bool = true;
                                            {
                                                (); // ?? / i': 9uy / n: 11uy;
                                                let v278: bool = true;
                                                {
                                                    (); // ?? / i': 10uy / n: 11uy;
                                                    let v280: bool = true;
                                                    {
                                                        (); // ?? / i': 11uy / n: 11uy;
                                                        let v282: bool = true;
                                                        {
                                                            {
                                                                (); // ? / i': 12uy / n: 11uy;
                                                                ()
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Dice_contract::closure0((), ())))
                .clone()
        }
        on_startup!(());
    }
}
pub use module_491a246d::*;
#[path = "../../polyglot/lib/fsharp/Common_contract.rs"]
mod module_ad43931;
pub use module_ad43931::*;
#[path = "../../polyglot/lib/spiral/async__contract.rs"]
mod module_67c461a2;
pub use module_67c461a2::*;
#[path = "../../polyglot/lib/spiral/common_contract.rs"]
mod module_181b15d6;
pub use module_181b15d6::*;
#[path = "../../polyglot/lib/spiral/crypto_contract.rs"]
mod module_90d9c778;
pub use module_90d9c778::*;
#[path = "../../polyglot/lib/spiral/date_time_contract.rs"]
mod module_e43a8385;
pub use module_e43a8385::*;
#[path = "../../polyglot/lib/spiral/file_system_contract.rs"]
mod module_a7db9b47;
pub use module_a7db9b47::*;
#[path = "../../polyglot/lib/spiral/lib_contract.rs"]
mod module_98e448fc;
pub use module_98e448fc::*;
#[path = "../../polyglot/lib/spiral/networking_contract.rs"]
mod module_268024e5;
pub use module_268024e5::*;
#[path = "../../polyglot/lib/spiral/platform_contract.rs"]
mod module_7d8ad484;
pub use module_7d8ad484::*;
#[path = "../../polyglot/lib/spiral/runtime_contract.rs"]
mod module_485aae07;
pub use module_485aae07::*;
#[path = "../../polyglot/lib/spiral/sm_contract.rs"]
mod module_582b4305;
pub use module_582b4305::*;
#[path = "../../polyglot/lib/spiral/threading_contract.rs"]
mod module_d5afb6f5;
pub use module_d5afb6f5::*;
#[path = "../../polyglot/lib/spiral/trace_contract.rs"]
mod module_9e77af3a;
pub use module_9e77af3a::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
