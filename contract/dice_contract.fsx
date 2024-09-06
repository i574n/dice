#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("*/ $0 /*")>]
#endif
type TypeEmit<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("&$0")>]
#endif
type Ref<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("near_sdk::store::vec::Vector<$0>")>]
#endif
type near_sdk_store_vec_Vector<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("[$0]")>]
#endif
type Slice<'T> = class end
#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("mut $0")>]
#endif
type Mut<'T> = class end
let rec closure0 () () : unit =
    let v0 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "pub struct Util {} //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "impl Util { //"
    Fable.Core.RustInterop.emitRustExpr () v2 
    let v3 : string = "    fn stream_u8_to_list( //"
    Fable.Core.RustInterop.emitRustExpr () v3 
    let v4 : string = "        s: fable_library_rust::Native_::LrcPtr<dice_contract_lib::Dice::UH0>, //"
    Fable.Core.RustInterop.emitRustExpr () v4 
    let v5 : string = "    ) -> dice_contract_lib::Dice::UH1 { //"
    Fable.Core.RustInterop.emitRustExpr () v5 
    let v6 : string = "        match s.as_ref() { //"
    Fable.Core.RustInterop.emitRustExpr () v6 
    let v7 : string = "            dice_contract_lib::Dice::UH0::UH0_0(n, f) => { //"
    Fable.Core.RustInterop.emitRustExpr () v7 
    let v8 : string = "                dice_contract_lib::Dice::UH1::UH1_1(*n, Self::stream_u8_to_list(f()).into()) //"
    Fable.Core.RustInterop.emitRustExpr () v8 
    let v9 : string = "            } //"
    Fable.Core.RustInterop.emitRustExpr () v9 
    let v10 : string = "            dice_contract_lib::Dice::UH0::UH0_1 => dice_contract_lib::Dice::UH1::UH1_0, //"
    Fable.Core.RustInterop.emitRustExpr () v10 
    let v11 : string = "        } //"
    Fable.Core.RustInterop.emitRustExpr () v11 
    let v12 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v12 
    let v13 : string = "    fn list_u8_to_vec( //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "        s: fable_library_rust::Native_::LrcPtr<dice_contract_lib::Dice::UH1>, //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "    ) -> Vec<u8> { //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "        match s.as_ref() { //"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "            dice_contract_lib::Dice::UH1::UH1_1(n, f) => { //"
    Fable.Core.RustInterop.emitRustExpr () v17 
    let v18 : string = "                let mut v = Self::list_u8_to_vec(f.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v18 
    let v19 : string = "                v.insert(0, *n); //"
    Fable.Core.RustInterop.emitRustExpr () v19 
    let v20 : string = "                v //"
    Fable.Core.RustInterop.emitRustExpr () v20 
    let v21 : string = "            } //"
    Fable.Core.RustInterop.emitRustExpr () v21 
    let v22 : string = "            dice_contract_lib::Dice::UH1::UH1_0 => vec![], //"
    Fable.Core.RustInterop.emitRustExpr () v22 
    let v23 : string = "        } //"
    Fable.Core.RustInterop.emitRustExpr () v23 
    let v24 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v24 
    let v25 : string = "    fn vec_u8_to_list(v: Vec<u8>) -> dice_contract_lib::Dice::UH1 { //"
    Fable.Core.RustInterop.emitRustExpr () v25 
    let v26 : string = "        v.iter() //"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "            .rev() //"
    Fable.Core.RustInterop.emitRustExpr () v27 
    let v28 : string = "            .fold(dice_contract_lib::Dice::UH1::UH1_0, |acc, x| { //"
    Fable.Core.RustInterop.emitRustExpr () v28 
    let v29 : string = "                dice_contract_lib::Dice::UH1::UH1_1(*x, acc.into()) //"
    Fable.Core.RustInterop.emitRustExpr () v29 
    let v30 : string = "            }) //"
    Fable.Core.RustInterop.emitRustExpr () v30 
    let v31 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v31 
    let v32 : string = "    fn vec_u8_to_stream(v: Vec<u8>) -> dice_contract_lib::Dice::UH0 { //"
    Fable.Core.RustInterop.emitRustExpr () v32 
    let v33 : string = "        v.iter() //"
    Fable.Core.RustInterop.emitRustExpr () v33 
    let v34 : string = "            .rev() //"
    Fable.Core.RustInterop.emitRustExpr () v34 
    let v35 : string = "            .fold(dice_contract_lib::Dice::UH0::UH0_1, |acc, x| { //"
    Fable.Core.RustInterop.emitRustExpr () v35 
    let v36 : string = "                dice_contract_lib::Dice::UH0::UH0_0( //"
    Fable.Core.RustInterop.emitRustExpr () v36 
    let v37 : string = "                    *x, //"
    Fable.Core.RustInterop.emitRustExpr () v37 
    let v38 : string = "                    fable_library_rust::Native_::Func0::new(move || acc.clone().into()), //"
    Fable.Core.RustInterop.emitRustExpr () v38 
    let v39 : string = "                ) //"
    Fable.Core.RustInterop.emitRustExpr () v39 
    let v40 : string = "            }) //"
    Fable.Core.RustInterop.emitRustExpr () v40 
    let v41 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v41 
    let v42 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v42 
    let v43 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v43 
    let v44 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v44 
    let v45 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v45 
    let v46 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v46 
    let v47 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v47 
    let v48 : string = "pub struct OldState { //"
    Fable.Core.RustInterop.emitRustExpr () v48 
    let v49 : string = "    version: u32, //"
    Fable.Core.RustInterop.emitRustExpr () v49 
    let v50 : string = "    seeds: near_sdk::store::vec::Vector<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v50 
    let v51 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v51 
    let v52 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v52 
    let v53 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v53 
    let v54 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v54 
    let v55 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v55 
    let v56 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v56 
    let v57 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v57 
    let v58 : string = "pub struct State ( //"
    Fable.Core.RustInterop.emitRustExpr () v58 
    let v59 : string = "/*"
    Fable.Core.RustInterop.emitRustExpr () v59 
    let v60 : TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)> = null |> unbox<TypeEmit<struct (uint32 * near_sdk_store_vec_Vector<uint8>)>>
    let v63 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v63 
    let v64 : string = "impl From<OldState> for State { //"
    Fable.Core.RustInterop.emitRustExpr () v64 
    let v65 : string = "    fn from(old_state: OldState) -> Self { //"
    Fable.Core.RustInterop.emitRustExpr () v65 
    let v66 : string = "        Self((old_state.version, old_state.seeds)) //"
    Fable.Core.RustInterop.emitRustExpr () v66 
    let v67 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v67 
    let v68 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v68 
    let v69 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v69 
    let v70 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v70 
    let v71 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v71 
    let v72 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v72 
    let v73 : string = "true; /*"
    let v74 : bool = Fable.Core.RustInterop.emitRustExpr () v73 
    let v75 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v78 : string = "true; */"
    let v79 : bool = Fable.Core.RustInterop.emitRustExpr () v78 
    let v80 : string = "seeds"
    let v81 : string = "b\"" + v80 + "\""
    let v82 : Ref<Slice<uint8>> = Fable.Core.RustInterop.emitRustExpr () v81 
    let v83 : string = "near_sdk::store::vec::Vector::new(v82)"
    let v84 : near_sdk_store_vec_Vector<uint8> = Fable.Core.RustInterop.emitRustExpr () v83 
    let _result = struct (1u, v84) in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v85 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v85 
    let v86 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v86 
    let v87 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v87 
    let v88 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v89 : bool = Fable.Core.RustInterop.emitRustExpr () v88 
    let v90 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v91 : bool = Fable.Core.RustInterop.emitRustExpr () v90 
    let v92 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v92 
    let v93 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v93 
    let v94 : string = "pub fn contribute_seed(&mut self, seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v94 
    let v95 : string = $"&mut self.0.1"
    let v96 : Ref<Mut<near_sdk_store_vec_Vector<uint8>>> = Fable.Core.RustInterop.emitRustExpr () v95 
    let v97 : string = "    v96.extend(seed); //"
    Fable.Core.RustInterop.emitRustExpr () v97 
    let v98 : unativeint = 100 |> unativeint 
    let v101 : string = "    let seed_excess_len = (v96.len() as i32) - v98 as i32; //"
    Fable.Core.RustInterop.emitRustExpr () v101 
    let v102 : string = "    if seed_excess_len > 0 { //"
    Fable.Core.RustInterop.emitRustExpr () v102 
    let v103 : string = "        let seed_excess: Vec<_> = v96.drain(0..seed_excess_len as u32).collect(); //"
    Fable.Core.RustInterop.emitRustExpr () v103 
    let v104 : string = "        near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v104 
    let v105 : string = "            \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v105 
    let v106 : string = "            format!( //"
    Fable.Core.RustInterop.emitRustExpr () v106 
    let v107 : string = "                \"contribute_seed / seed_excess: {seed_excess:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v107 
    let v108 : string = "            ) //"
    Fable.Core.RustInterop.emitRustExpr () v108 
    let v109 : string = "        ); //"
    Fable.Core.RustInterop.emitRustExpr () v109 
    let v110 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v110 
    let v111 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v111 
    let v112 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v112 
    let v113 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v113 
    let v114 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v114 
    let v115 : string = "true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 3uy"
    let v116 : bool = Fable.Core.RustInterop.emitRustExpr () v115 
    let v117 : string = "true; */ // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 3uy"
    let v118 : bool = Fable.Core.RustInterop.emitRustExpr () v117 
    let v119 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v119 
    let v120 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v120 
    let v121 : string = "pub fn contribute_seed_borsh(&mut self, #[serializer(borsh)] seed: Vec<u8>) { //"
    Fable.Core.RustInterop.emitRustExpr () v121 
    let v122 : string = "    self.contribute_seed(seed) //"
    Fable.Core.RustInterop.emitRustExpr () v122 
    let v123 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v123 
    let v124 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v124 
    let v125 : string = "true; // ??? / i: 3uy / i': 1uy / acc: 5uy / n: 1uy"
    let v126 : bool = Fable.Core.RustInterop.emitRustExpr () v125 
    let v127 : string = "true; */ // ???? / i: 3uy / i': 2uy / acc: 5uy / n: 1uy"
    let v128 : bool = Fable.Core.RustInterop.emitRustExpr () v127 
    let v129 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v129 
    let v130 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v130 
    let v131 : string = "fn get_logger() -> fable_library_rust::Native_::Func1<fable_library_rust::String_::string, ()> { //"
    Fable.Core.RustInterop.emitRustExpr () v131 
    let v132 : string = "    let count = std::rc::Rc::new(std::cell::RefCell::new(0)); //"
    Fable.Core.RustInterop.emitRustExpr () v132 
    let v133 : string = "    let acc = std::rc::Rc::new(std::cell::RefCell::new(String::new())); //"
    Fable.Core.RustInterop.emitRustExpr () v133 
    let v134 : string = "    let closure = { //"
    Fable.Core.RustInterop.emitRustExpr () v134 
    let v135 : string = "        let count = std::rc::Rc::clone(&count); //"
    Fable.Core.RustInterop.emitRustExpr () v135 
    let v136 : string = "        let acc = std::rc::Rc::clone(&acc); //"
    Fable.Core.RustInterop.emitRustExpr () v136 
    let v137 : string = "        move |s: fable_library_rust::String_::string| { //"
    Fable.Core.RustInterop.emitRustExpr () v137 
    let v138 : string = "            let mut count_ref = count.borrow_mut(); //"
    Fable.Core.RustInterop.emitRustExpr () v138 
    let v139 : string = "            let mut acc_ref = acc.borrow_mut(); //"
    Fable.Core.RustInterop.emitRustExpr () v139 
    let v140 : string = "            *count_ref += 1; //"
    Fable.Core.RustInterop.emitRustExpr () v140 
    let v141 : string = "            if s.len() == 0 || *count_ref % 6 == 0 { //"
    Fable.Core.RustInterop.emitRustExpr () v141 
    let v142 : string = "                near_sdk::log!(\"{:?}\", acc_ref.clone().drain(..acc_ref.len() - 1)); //"
    Fable.Core.RustInterop.emitRustExpr () v142 
    let v143 : string = "                *acc_ref = String::new(); //"
    Fable.Core.RustInterop.emitRustExpr () v143 
    let v144 : string = "            } //"
    Fable.Core.RustInterop.emitRustExpr () v144 
    let v145 : string = "            acc_ref.push_str(&(s.to_string() + \"
\")); //"
    Fable.Core.RustInterop.emitRustExpr () v145 
    let v146 : string = "        } //"
    Fable.Core.RustInterop.emitRustExpr () v146 
    let v147 : string = "    }; //"
    Fable.Core.RustInterop.emitRustExpr () v147 
    let v148 : string = "    fable_library_rust::Native_::Func1::new(closure) //"
    Fable.Core.RustInterop.emitRustExpr () v148 
    let v149 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v149 
    let v150 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v150 
    let v151 : string = "true; // ??? / i: 4uy / i': 1uy / acc: 6uy / n: 1uy"
    let v152 : bool = Fable.Core.RustInterop.emitRustExpr () v151 
    let v153 : string = "true; */ // ???? / i: 4uy / i': 2uy / acc: 6uy / n: 1uy"
    let v154 : bool = Fable.Core.RustInterop.emitRustExpr () v153 
    let v155 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v155 
    let v156 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v156 
    let v157 : string = "pub fn generate_random_number(&mut self, key: String, proof: String, max: u64) -> u64 { //"
    Fable.Core.RustInterop.emitRustExpr () v157 
    let v158 : string = $"&self.0.1"
    let v159 : Ref<near_sdk_store_vec_Vector<uint8>> = Fable.Core.RustInterop.emitRustExpr () v158 
    let v160 : string = "    let seed = near_sdk::env::random_seed(); //"
    Fable.Core.RustInterop.emitRustExpr () v160 
    let v161 : string = "    let block_timestamp = near_sdk::env::block_timestamp(); //"
    Fable.Core.RustInterop.emitRustExpr () v161 
    let v162 : string = "    let signer_account_id = near_sdk::env::signer_account_id(); //"
    Fable.Core.RustInterop.emitRustExpr () v162 
    let v163 : string = "    let account_balance = near_sdk::env::account_balance(); //"
    Fable.Core.RustInterop.emitRustExpr () v163 
    let v164 : string = "    let block_height = near_sdk::env::block_height(); //"
    Fable.Core.RustInterop.emitRustExpr () v164 
    let v165 : string = "    let epoch_height = near_sdk::env::epoch_height(); //"
    Fable.Core.RustInterop.emitRustExpr () v165 
    let v166 : string = "    let entropy: Vec<u8> = vec![ //"
    Fable.Core.RustInterop.emitRustExpr () v166 
    let v167 : string = "        seed.clone(), //"
    Fable.Core.RustInterop.emitRustExpr () v167 
    let v168 : string = "        block_timestamp.to_le_bytes().to_vec(), //"
    Fable.Core.RustInterop.emitRustExpr () v168 
    let v169 : string = "        block_height.to_le_bytes().to_vec(), //"
    Fable.Core.RustInterop.emitRustExpr () v169 
    let v170 : string = "        epoch_height.to_le_bytes().to_vec(), //"
    Fable.Core.RustInterop.emitRustExpr () v170 
    let v171 : string = "        account_balance.as_yoctonear().to_le_bytes().to_vec(), //"
    Fable.Core.RustInterop.emitRustExpr () v171 
    let v172 : string = "        signer_account_id.as_bytes().to_vec(), //"
    Fable.Core.RustInterop.emitRustExpr () v172 
    let v173 : string = "        v159.iter().map(|x| *x).collect::<Vec<u8>>(), //"
    Fable.Core.RustInterop.emitRustExpr () v173 
    let v174 : string = "        key.clone().into_bytes(), //"
    Fable.Core.RustInterop.emitRustExpr () v174 
    let v175 : string = "        proof.clone().into_bytes(), //"
    Fable.Core.RustInterop.emitRustExpr () v175 
    let v176 : string = "    ].concat(); //"
    Fable.Core.RustInterop.emitRustExpr () v176 
    let v177 : string = "    let hash_u8 = near_sdk::env::keccak512(&entropy); //"
    Fable.Core.RustInterop.emitRustExpr () v177 
    let v178 : string = "    self.contribute_seed(hash_u8.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v178 
    let v179 : string = "    let hash_stream = Util::vec_u8_to_stream(hash_u8.clone()); //"
    Fable.Core.RustInterop.emitRustExpr () v179 
    let v180 : string = "    let rolls_list = Util::stream_u8_to_list(dice_contract_lib::Dice::rotate_numbers(6)( //"
    Fable.Core.RustInterop.emitRustExpr () v180 
    let v181 : string = "        hash_stream.into(), //"
    Fable.Core.RustInterop.emitRustExpr () v181 
    let v182 : string = "    )); //"
    Fable.Core.RustInterop.emitRustExpr () v182 
    let v183 : string = "    { //"
    Fable.Core.RustInterop.emitRustExpr () v183 
    let v184 : string = "        let rolls_list_log = Util::list_u8_to_vec(rolls_list.clone().into()); //"
    Fable.Core.RustInterop.emitRustExpr () v184 
    let v185 : string = "        let signer_account_id_log = signer_account_id.as_str(); //"
    Fable.Core.RustInterop.emitRustExpr () v185 
    let v186 : string = "        near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v186 
    let v187 : string = "            \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v187 
    let v188 : string = "            format!( //"
    Fable.Core.RustInterop.emitRustExpr () v188 
    let v189 : string = "                \"{}\", (\"generate_random_number\".to_owned() //"
    Fable.Core.RustInterop.emitRustExpr () v189 
    let v190 : string = "                + \" / max: {max:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v190 
    let v191 : string = "                + \" / key: {key:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v191 
    let v192 : string = "                + \" / proof: {proof:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v192 
    let v193 : string = "                + \" / block_timestamp: {block_timestamp:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v193 
    let v194 : string = "                + \" / block_height: {block_height:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v194 
    let v195 : string = "                + \" / epoch_height: {epoch_height:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v195 
    let v196 : string = "                + \" / account_balance: {account_balance:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v196 
    let v197 : string = "                + \" / signer_account_id: {signer_account_id_log:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v197 
    let v198 : string = "                + \" / seed: {seed:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v198 
    let v199 : string = "                + \" / entropy: {entropy:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v199 
    let v200 : string = "                + \" / hash_u8: {hash_u8:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v200 
    let v201 : string = "                + \" / rolls_list: {rolls_list_log:?}\") //"
    Fable.Core.RustInterop.emitRustExpr () v201 
    let v202 : string = "            ) //"
    Fable.Core.RustInterop.emitRustExpr () v202 
    let v203 : string = "        ); //"
    Fable.Core.RustInterop.emitRustExpr () v203 
    let v204 : string = "    } //"
    Fable.Core.RustInterop.emitRustExpr () v204 
    let v205 : string = "    let logger = Self::get_logger(); //"
    Fable.Core.RustInterop.emitRustExpr () v205 
    let v206 : string = "    let sequential_roll = dice_contract_lib::Dice::create_sequential_roller(Some( //"
    Fable.Core.RustInterop.emitRustExpr () v206 
    let v207 : string = "        logger.clone(), //"
    Fable.Core.RustInterop.emitRustExpr () v207 
    let v208 : string = "    ))(rolls_list.into()); //"
    Fable.Core.RustInterop.emitRustExpr () v208 
    let v209 : string = "    let result = dice_contract_lib::Dice::roll_progressively(Some(logger.clone()))( //"
    Fable.Core.RustInterop.emitRustExpr () v209 
    let v210 : string = "        sequential_roll, //"
    Fable.Core.RustInterop.emitRustExpr () v210 
    let v211 : string = "    )(true)(max); //"
    Fable.Core.RustInterop.emitRustExpr () v211 
    let v212 : string = "    logger(\"\".into()); //"
    Fable.Core.RustInterop.emitRustExpr () v212 
    let v213 : string = "    result as u64 //"
    Fable.Core.RustInterop.emitRustExpr () v213 
    let v214 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v214 
    let v215 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v215 
    let v216 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v216 
    let v217 : string = "true; // ??? / i: 5uy / i': 1uy / acc: 7uy / n: 2uy"
    let v218 : bool = Fable.Core.RustInterop.emitRustExpr () v217 
    let v219 : string = "true; */ // ???? / i: 5uy / i': 2uy / acc: 7uy / n: 2uy"
    let v220 : bool = Fable.Core.RustInterop.emitRustExpr () v219 
    let v221 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v221 
    let v222 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v222 
    let v223 : string = "pub fn roll_within_bounds(&self, max: u64, rolls: Vec<u8>) -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v223 
    let v224 : string = "    near_sdk::log!( //"
    Fable.Core.RustInterop.emitRustExpr () v224 
    let v225 : string = "        \"{}\", //"
    Fable.Core.RustInterop.emitRustExpr () v225 
    let v226 : string = "        format!( //"
    Fable.Core.RustInterop.emitRustExpr () v226 
    let v227 : string = "            \"roll_within_bounds / max: {max:#?} / rolls: {rolls:?}\" //"
    Fable.Core.RustInterop.emitRustExpr () v227 
    let v228 : string = "        ) //"
    Fable.Core.RustInterop.emitRustExpr () v228 
    let v229 : string = "    ); //"
    Fable.Core.RustInterop.emitRustExpr () v229 
    let v230 : string = "    let rolls = Util::vec_u8_to_list(rolls); //"
    Fable.Core.RustInterop.emitRustExpr () v230 
    let v231 : string = "    let logger = Self::get_logger(); //"
    Fable.Core.RustInterop.emitRustExpr () v231 
    let v232 : string = "    let result = //"
    Fable.Core.RustInterop.emitRustExpr () v232 
    let v233 : string = "        dice_contract_lib::Dice::roll_within_bounds(Some(logger.clone()))(max)(rolls.into()); //"
    Fable.Core.RustInterop.emitRustExpr () v233 
    let v234 : string = "    logger(\"\".into()); //"
    Fable.Core.RustInterop.emitRustExpr () v234 
    let v235 : string = "    result //"
    Fable.Core.RustInterop.emitRustExpr () v235 
    let v236 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v236 
    let v237 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v237 
    let v238 : string = "true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 1uy"
    let v239 : bool = Fable.Core.RustInterop.emitRustExpr () v238 
    let v240 : string = "true; */ // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 1uy"
    let v241 : bool = Fable.Core.RustInterop.emitRustExpr () v240 
    let v242 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v242 
    let v243 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v243 
    let v244 : string = "#[result_serializer(borsh)] //"
    Fable.Core.RustInterop.emitRustExpr () v244 
    let v245 : string = "pub fn roll_within_bounds_borsh( //"
    Fable.Core.RustInterop.emitRustExpr () v245 
    let v246 : string = "    &self, //"
    Fable.Core.RustInterop.emitRustExpr () v246 
    let v247 : string = "    #[serializer(borsh)] max: u64, //"
    Fable.Core.RustInterop.emitRustExpr () v247 
    let v248 : string = "    #[serializer(borsh)] rolls: Vec<u8>, //"
    Fable.Core.RustInterop.emitRustExpr () v248 
    let v249 : string = ") -> Option<u64> { //"
    Fable.Core.RustInterop.emitRustExpr () v249 
    let v250 : string = "    self.roll_within_bounds(max, rolls) //"
    Fable.Core.RustInterop.emitRustExpr () v250 
    let v251 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v251 
    let v252 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v252 
    let v253 : string = "true; // ??? / i: 7uy / i': 1uy / acc: 10uy / n: 1uy"
    let v254 : bool = Fable.Core.RustInterop.emitRustExpr () v253 
    let v255 : string = "true; */ // ???? / i: 7uy / i': 2uy / acc: 10uy / n: 1uy"
    let v256 : bool = Fable.Core.RustInterop.emitRustExpr () v255 
    let v257 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v257 
    let v258 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v258 
    let v259 : string = "true; { (); // ?? / i': 1uy / n: 11uy"
    let v260 : bool = Fable.Core.RustInterop.emitRustExpr () v259 
    let v261 : string = "true; { (); // ?? / i': 2uy / n: 11uy"
    let v262 : bool = Fable.Core.RustInterop.emitRustExpr () v261 
    let v263 : string = "true; { (); // ?? / i': 3uy / n: 11uy"
    let v264 : bool = Fable.Core.RustInterop.emitRustExpr () v263 
    let v265 : string = "true; { (); // ?? / i': 4uy / n: 11uy"
    let v266 : bool = Fable.Core.RustInterop.emitRustExpr () v265 
    let v267 : string = "true; { (); // ?? / i': 5uy / n: 11uy"
    let v268 : bool = Fable.Core.RustInterop.emitRustExpr () v267 
    let v269 : string = "true; { (); // ?? / i': 6uy / n: 11uy"
    let v270 : bool = Fable.Core.RustInterop.emitRustExpr () v269 
    let v271 : string = "true; { (); // ?? / i': 7uy / n: 11uy"
    let v272 : bool = Fable.Core.RustInterop.emitRustExpr () v271 
    let v273 : string = "true; { (); // ?? / i': 8uy / n: 11uy"
    let v274 : bool = Fable.Core.RustInterop.emitRustExpr () v273 
    let v275 : string = "true; { (); // ?? / i': 9uy / n: 11uy"
    let v276 : bool = Fable.Core.RustInterop.emitRustExpr () v275 
    let v277 : string = "true; { (); // ?? / i': 10uy / n: 11uy"
    let v278 : bool = Fable.Core.RustInterop.emitRustExpr () v277 
    let v279 : string = "true; { (); // ?? / i': 11uy / n: 11uy"
    let v280 : bool = Fable.Core.RustInterop.emitRustExpr () v279 
    let v281 : string = "true; { { (); // ? / i': 12uy / n: 11uy"
    let v282 : bool = Fable.Core.RustInterop.emitRustExpr () v281 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
