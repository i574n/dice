pub mod dice_ui_wasm;
pub mod js;
pub mod model;
pub mod state;

#[allow(non_snake_case)]
#[allow(unused_imports)]
#[path = "../../../polyglot/lib/spiral/lib_wasm.rs"]
pub mod lib;
pub use lib::Lib;
pub use lib::Lib::*;

#[allow(non_snake_case)]
#[allow(unused_imports)]
#[allow(unused_variables)]
#[allow(unreachable_code)]
#[allow(non_upper_case_globals)]
#[path = "../../../polyglot/lib/spiral/file_system.rs"]
pub mod _File_system;
pub use _File_system::File_system;

#[allow(non_snake_case)]
#[allow(unused_imports)]
#[allow(unused_variables)]
#[allow(non_upper_case_globals)]
#[path = "../../../polyglot/lib/spiral/sm.rs"]
pub mod _Sm;
pub use _Sm::Sm;

pub fn main() {
    dice_ui_wasm::main()
}
