pub mod dice_ui_wasm;
pub mod js;
#[allow(non_snake_case)]
#[allow(unused_imports)]
#[allow(unconditional_recursion)]
#[path = "../../../polyglot/lib/spiral/lib.rs"]
pub mod lib;
pub use lib::Lib;
pub use lib::Lib::*;
pub mod model;
pub mod state;

pub fn main() {
    dice_ui_wasm::main()
}
