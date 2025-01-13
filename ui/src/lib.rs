pub mod dice_ui_wasm;
pub mod js;
pub mod model;
pub mod state;

#[path = "../../deps/polyglot/deps/spiral/lib/spiral/lib_spiral_wasm.rs"]
pub mod lib_spiral;
pub use lib_spiral::*;

pub fn main() {
    dice_ui_wasm::main()
}
