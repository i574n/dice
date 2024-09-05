#if FABLE_COMPILER
[<Fable.Core.Erase; Fable.Core.Emit("*/ $0 /*")>]
#endif
type TypeEmit<'T> = class end
let rec closure0 () () : unit =
    let v0 : string = "} //"
    Fable.Core.RustInterop.emitRustExpr () v0 
    let v1 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v1 
    let v2 : string = "#[derive( //"
    Fable.Core.RustInterop.emitRustExpr () v2 
    let v3 : string = "  near_sdk::PanicOnDefault, //"
    Fable.Core.RustInterop.emitRustExpr () v3 
    let v4 : string = "  borsh::BorshDeserialize, //"
    Fable.Core.RustInterop.emitRustExpr () v4 
    let v5 : string = "  borsh::BorshSerialize, //"
    Fable.Core.RustInterop.emitRustExpr () v5 
    let v6 : string = ")] //"
    Fable.Core.RustInterop.emitRustExpr () v6 
    let v7 : string = "pub struct State ( //"
    Fable.Core.RustInterop.emitRustExpr () v7 
    let v8 : string = "/*"
    Fable.Core.RustInterop.emitRustExpr () v8 
    let v9 : TypeEmit<uint32> = null |> unbox<TypeEmit<uint32>>
    let v12 : string = "*/ )"
    Fable.Core.RustInterop.emitRustExpr () v12 
    let v13 : string = "#[near_sdk::near_bindgen] //"
    Fable.Core.RustInterop.emitRustExpr () v13 
    let v14 : string = "impl State { //"
    Fable.Core.RustInterop.emitRustExpr () v14 
    let v15 : string = "#[init] //"
    Fable.Core.RustInterop.emitRustExpr () v15 
    let v16 : string = "pub fn new() -> Self { // 1"
    Fable.Core.RustInterop.emitRustExpr () v16 
    let v17 : string = "true; /*"
    let v18 : bool = Fable.Core.RustInterop.emitRustExpr () v17 
    let v19 : TypeEmit<unit> = null |> unbox<TypeEmit<unit>>
    let v22 : string = "true; */"
    let v23 : bool = Fable.Core.RustInterop.emitRustExpr () v22 
    let _result = 1u in _result |> (fun x -> Fable.Core.RustInterop.emitRustExpr x $"Self($0) // x") // 2
    let v24 : string = "} // 2."
    Fable.Core.RustInterop.emitRustExpr () v24 
    let v25 : string = "} // 1."
    Fable.Core.RustInterop.emitRustExpr () v25 
    let v26 : string = "} /* c"
    Fable.Core.RustInterop.emitRustExpr () v26 
    let v27 : string = "true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy"
    let v28 : bool = Fable.Core.RustInterop.emitRustExpr () v27 
    let v29 : string = "true; */ // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy"
    let v30 : bool = Fable.Core.RustInterop.emitRustExpr () v29 
    let v31 : string = "fn _main() //"
    Fable.Core.RustInterop.emitRustExpr () v31 
    let v32 : string = " //"
    Fable.Core.RustInterop.emitRustExpr () v32 
    let v33 : string = "true; { (); // ?? / i': 1uy / n: 2uy"
    let v34 : bool = Fable.Core.RustInterop.emitRustExpr () v33 
    let v35 : string = "true; { (); // ?? / i': 2uy / n: 2uy"
    let v36 : bool = Fable.Core.RustInterop.emitRustExpr () v35 
    let v37 : string = "true; { { (); // ? / i': 3uy / n: 2uy"
    let v38 : bool = Fable.Core.RustInterop.emitRustExpr () v37 
    ()
let v0 : (unit -> unit) = closure0()
v0 |> ignore
()
