<?php
namespace Dice;

require_once(__FABLE_LIBRARY__.'/BigInt.php');
require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/String.php');

use \FSharpUnion;
use \IComparable;

#0
abstract class UH0 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\UH0_UH0_0', '\\Dice\\UH0_UH0_1' ];
    }
}

#0
class UH0_UH0_0 extends UH0 implements IComparable {
    public $Item1;
    public $Item2;
    function __construct($Item1, $Item2) {
        $this->Item1 = $Item1;
        $this->Item2 = $Item2;
    }
    static function get_FSharpCase() {
        return 'UH0_0';
    }
    static function get_Item1_Type() {
        return 'UInt8';
    }
    static function get_Item2_Type() {
        return '??? \'LambdaType
  (Unit,
   DeclaredType
     ({ FullName = "Dice.UH0"
        Path =
         SourcePath
           "/home/runner/work/dice/polyglot/target/polyglot/builder/dice/dice.fs" },
      []))\'';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__1 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__1 != 0) {
            return $_cmp__1;
        }        
        $_cmp__2 = $this->Item1 > $other->Item1 ? 1 : ($this->Item1 < $other->Item1 ? -1 : 0);
        if ($_cmp__2 != 0) {
            return $_cmp__2;
        }        
        $_cmp__3 = $this->Item2->CompareTo($other->Item2);
        if ($_cmp__3 != 0) {
            return $_cmp__3;
        }        
        return 0;
    }
}

#0
class UH0_UH0_1 extends UH0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'UH0_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__4 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__4;
    }
}

#1
abstract class UH1 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\UH1_UH1_0', '\\Dice\\UH1_UH1_1' ];
    }
}

#1
class UH1_UH1_0 extends UH1 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'UH1_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__5 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__5;
    }
}

#1
class UH1_UH1_1 extends UH1 implements IComparable {
    public $Item1;
    public $Item2;
    function __construct($Item1, $Item2) {
        $this->Item1 = $Item1;
        $this->Item2 = $Item2;
    }
    static function get_FSharpCase() {
        return 'UH1_1';
    }
    static function get_Item1_Type() {
        return 'UInt8';
    }
    static function get_Item2_Type() {
        return '\\Dice\\UH1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__6 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__6 != 0) {
            return $_cmp__6;
        }        
        $_cmp__7 = $this->Item1 > $other->Item1 ? 1 : ($this->Item1 < $other->Item1 ? -1 : 0);
        if ($_cmp__7 != 0) {
            return $_cmp__7;
        }        
        $_cmp__8 = $this->Item2->CompareTo($other->Item2);
        if ($_cmp__8 != 0) {
            return $_cmp__8;
        }        
        return 0;
    }
}

#2
abstract class US0 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US0_US0_0', '\\Dice\\US0_US0_1' ];
    }
}

#2
class US0_US0_0 extends US0 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US0_0';
    }
    static function get_f0_0_Type() {
        return '??? \'LambdaType (String, Unit)\'';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__9 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__9 != 0) {
            return $_cmp__9;
        }        
        $_cmp__10 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__10 != 0) {
            return $_cmp__10;
        }        
        return 0;
    }
}

#2
class US0_US0_1 extends US0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__11 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__11;
    }
}

#3
abstract class US1 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US1_US1_0', '\\Dice\\US1_US1_1' ];
    }
}

#3
class US1_US1_0 extends US1 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US1_0';
    }
    static function get_f0_0_Type() {
        return '??? \'LambdaType
  (Unit,
   DeclaredType
     ({ FullName = "Dice.UH0"
        Path =
         SourcePath
           "/home/runner/work/dice/polyglot/target/polyglot/builder/dice/dice.fs" },
      []))\'';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__12 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__12 != 0) {
            return $_cmp__12;
        }        
        $_cmp__13 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__13 != 0) {
            return $_cmp__13;
        }        
        return 0;
    }
}

#3
class US1_US1_1 extends US1 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US1_1';
    }
    static function get_f1_0_Type() {
        return '\\Dice\\UH0';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__14 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__14 != 0) {
            return $_cmp__14;
        }        
        $_cmp__15 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__15 != 0) {
            return $_cmp__15;
        }        
        return 0;
    }
}

#4
class Mut0 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '\\Dice\\US1';
    }
    function CompareTo($other) {
        $_cmp__16 = $this->l0->CompareTo($other->l0);
        if ($_cmp__16 != 0) {
            return $_cmp__16;
        }        
        return 0;
    }
}

#5
class Mut1 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return 'Int64';
    }
    function CompareTo($other) {
        $_cmp__17 = $this->l0 > $other->l0 ? 1 : ($this->l0 < $other->l0 ? -1 : 0);
        if ($_cmp__17 != 0) {
            return $_cmp__17;
        }        
        return 0;
    }
}

#6
abstract class US2 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US2_US2_0', '\\Dice\\US2_US2_1' ];
    }
}

#6
class US2_US2_0 extends US2 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US2_0';
    }
    static function get_f0_0_Type() {
        return 'UInt8';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__18 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__18 != 0) {
            return $_cmp__18;
        }        
        $_cmp__19 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__19 != 0) {
            return $_cmp__19;
        }        
        return 0;
    }
}

#6
class US2_US2_1 extends US2 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US2_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__20 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__20;
    }
}

#7
class Mut2 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '\\Dice\\US2';
    }
    function CompareTo($other) {
        $_cmp__21 = $this->l0->CompareTo($other->l0);
        if ($_cmp__21 != 0) {
            return $_cmp__21;
        }        
        return 0;
    }
}

#8
abstract class US3 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US3_US3_0', '\\Dice\\US3_US3_1' ];
    }
}

#8
class US3_US3_0 extends US3 implements IComparable {
    public $f0_0;
    public $f0_1;
    function __construct($f0_0, $f0_1) {
        $this->f0_0 = $f0_0;
        $this->f0_1 = $f0_1;
    }
    static function get_FSharpCase() {
        return 'US3_0';
    }
    static function get_f0_0_Type() {
        return 'UInt64';
    }
    static function get_f0_1_Type() {
        return '\\Dice\\UH1';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__22 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__22 != 0) {
            return $_cmp__22;
        }        
        $_cmp__23 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__23 != 0) {
            return $_cmp__23;
        }        
        $_cmp__24 = $this->f0_1->CompareTo($other->f0_1);
        if ($_cmp__24 != 0) {
            return $_cmp__24;
        }        
        return 0;
    }
}

#8
class US3_US3_1 extends US3 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US3_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__25 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__25;
    }
}

#9
abstract class UH2 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\UH2_UH2_0', '\\Dice\\UH2_UH2_1' ];
    }
}

#9
class UH2_UH2_0 extends UH2 implements IComparable {
    public $Item1;
    public $Item2;
    function __construct($Item1, $Item2) {
        $this->Item1 = $Item1;
        $this->Item2 = $Item2;
    }
    static function get_FSharpCase() {
        return 'UH2_0';
    }
    static function get_Item1_Type() {
        return 'UInt64';
    }
    static function get_Item2_Type() {
        return '??? \'LambdaType
  (Unit,
   DeclaredType
     ({ FullName = "Dice.UH2"
        Path =
         SourcePath
           "/home/runner/work/dice/polyglot/target/polyglot/builder/dice/dice.fs" },
      []))\'';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__26 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__26 != 0) {
            return $_cmp__26;
        }        
        $_cmp__27 = $this->Item1 > $other->Item1 ? 1 : ($this->Item1 < $other->Item1 ? -1 : 0);
        if ($_cmp__27 != 0) {
            return $_cmp__27;
        }        
        $_cmp__28 = $this->Item2->CompareTo($other->Item2);
        if ($_cmp__28 != 0) {
            return $_cmp__28;
        }        
        return 0;
    }
}

#9
class UH2_UH2_1 extends UH2 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'UH2_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__29 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__29;
    }
}

#10
abstract class US4 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US4_US4_0', '\\Dice\\US4_US4_1' ];
    }
}

#10
class US4_US4_0 extends US4 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US4_0';
    }
    static function get_f0_0_Type() {
        return 'UInt64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__30 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__30 != 0) {
            return $_cmp__30;
        }        
        $_cmp__31 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__31 != 0) {
            return $_cmp__31;
        }        
        return 0;
    }
}

#10
class US4_US4_1 extends US4 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US4_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__32 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__32;
    }
}

#11
abstract class US5 implements FSharpUnion {
    static function allCases() {
        return [ '\\Dice\\US5_US5_0', '\\Dice\\US5_US5_1' ];
    }
}

#11
class US5_US5_0 extends US5 implements IComparable {
    public $f0_0;
    public $f0_1;
    function __construct($f0_0, $f0_1) {
        $this->f0_0 = $f0_0;
        $this->f0_1 = $f0_1;
    }
    static function get_FSharpCase() {
        return 'US5_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    static function get_f0_1_Type() {
        return '\\Dice\\UH1';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__33 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__33 != 0) {
            return $_cmp__33;
        }        
        $_cmp__34 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__34 != 0) {
            return $_cmp__34;
        }        
        $_cmp__35 = $this->f0_1->CompareTo($other->f0_1);
        if ($_cmp__35 != 0) {
            return $_cmp__35;
        }        
        return 0;
    }
}

#11
class US5_US5_1 extends US5 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US5_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__36 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__36;
    }
}

#12
function UH0__get_IsUH0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#13
function UH0__get_IsUH0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#14
function UH1__get_IsUH1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#15
function UH1__get_IsUH1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#16
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#17
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#18
function US1__get_IsUS1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#19
function US1__get_IsUS1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#20
function US2__get_IsUS2_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#21
function US2__get_IsUS2_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#22
function US3__get_IsUS3_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#23
function US3__get_IsUS3_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#24
function UH2__get_IsUH2_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#25
function UH2__get_IsUH2_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#26
function US4__get_IsUS4_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#27
function US4__get_IsUS4_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#28
function US5__get_IsUS5_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#29
function US5__get_IsUS5_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#30
function closure2($v0_1, $unitVar) {
    return $v0_1;
}

#31
function method0($v0_1, $v1_1, $v2_1) {
    switch ($v1_1->get_Tag())
    {
        case 1:
            return $v2_1;
        default:
            $v6 = method0($v0_1, $v1_1->Item2(NULL), $v2_1);
            $v11 = \BigInt\toInt64(\BigInt\op_Addition(\BigInt\toInt64(\BigInt\op_Modulus(\BigInt\toInt64(\BigInt\op_Addition(\BigInt\toInt64(\BigInt\op_Subtraction(\BigInt\toInt64(\BigInt\fromUInt8($v1_1->Item1)), NULL)), $v0_1)), $v0_1)), NULL));
            return new UH0_UH0_0(\BigInt\toUInt8($v11) & 0xFF, function ($arg10_0040) use ($closure2, $v6) {             return closure2($v6, NULL);
 });
    }
}

#32
function closure1($v0_1, $v1_1) {
    return method0($v0_1, $v1_1, new UH0_UH0_1());
}

#33
function closure0($unitVar, $v0_1) {
    return function ($v) use ($closure1, $v0_1) {     return closure1($v0_1, $v);
 };
}

#34
function closure4($unitVar, $v0_1) {
    return new US0_US0_0($v0_1);
}

#35
function method1($unitVar) {
    return function ($v) use ($closure4) {     return closure4(NULL, $v);
 };
}

#36
function method2($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return $v1_1;
        default:
            return method2($v0_1->Item2, new UH1_UH1_1($v0_1->Item1, $v1_1));
    }
}

#37
function method3($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return $v1_1;
        default:
            return new UH1_UH1_1($v0_1->Item1, method3($v0_1->Item2, $v1_1));
    }
}

#38
function closure6($v0_1, $unitVar) {
    return $v0_1;
}

#39
function method4($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return $v1_1;
        default:
            $v4_1 = method4($v0_1->Item2, $v1_1);
            return new UH0_UH0_0($v0_1->Item1, function ($arg10_0040) use ($closure6, $v4_1) {             return closure6($v4_1, NULL);
 });
    }
}

#40
function closure7($v0_1, $unitVar) {
    return $v0_1;
}

#41
function closure8($v0_1, $v1_1, $unitVar) {
    $v2_1 = $v1_1->l0;
    switch ($v2_1->get_Tag())
    {
        case 0:
            $v5 = $v2_1->f0_0(NULL);
            switch ($v5->get_Tag())
            {
                case 1:
                    $v12 = new UH0_UH0_1();
                    break;
                default:
                    $v12 = new UH0_UH0_0($v5->Item1, $method5($v0_1, $v5->Item2));
                    break;
            }
            $v1_1->l0 = new US1_US1_1($v12);
            return $v12;
        default:
            return $v2_1->f1_0;
    }
}

#42
function method5($v0_1, $v1_1) {
    $v3_1 = new Mut0(new US1_US1_0($v1_1));
    return function ($arg10_0040) use ($closure8, $v0_1, $v3_1) {     return closure8($v0_1, $v3_1, NULL);
 };
}

#43
function method7($v0_1, $v1_1) {
    switch ($v1_1->get_Tag())
    {
        case 1:
            return new US2_US2_1();
        default:
            if (\BigInt\compare($v0_1, NULL) <= 0) {
                return new US2_US2_0($v1_1->Item1);
            } else {
                return method7(\BigInt\toInt64(\BigInt\op_Subtraction($v0_1, NULL)), $v1_1->Item2(NULL));
            }
    }
}

#44
function method6($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5) {
    $v10 = \String\toText(\String\interpolate('create_sequential_roller / roll / current_index: %P() / acc: %P() / len: %P() / last_item: %A%P()', [ $v2_1->l0, $v3_1->l0, $v4_1->l0, $v5->l0 ]));
    switch ($v0_1->get_Tag())
    {
        case 0:
            $v0_1->f0_0($v10);
            break;
        default:
            break;
    }
    $v12 = $v1_1(NULL);
    $v14 = method7($v2_1->l0, $v12);
    switch ($v14->get_Tag())
    {
        case 0:
            $v15 = $v14->f0_0;
            $v17 = \BigInt\toInt64(\BigInt\op_Addition($v2_1->l0, NULL));
            $v2_1->l0 = $v17;
            $v5->l0 = new US2_US2_0($v15);
            return $v15;
        default:
            switch ($v0_1->get_Tag())
            {
                case 0:
                    $v0_1->f0_0('create_sequential_roller / roll / None');
                    break;
                default:
                    break;
            }
            if (\BigInt\equals($v4_1->l0, NULL)) {
                $v23 = $v2_1->l0;
                $v4_1->l0 = $v23;
            } else {
            }
            if (\BigInt\compare($v3_1->l0, $v4_1->l0) >= 0) {
                $v29 = NULL;
            } else {
                $v29 = \BigInt\toInt64(\BigInt\op_Addition($v3_1->l0, NULL));
            }
            $v3_1->l0 = $v29;
            $v31 = \BigInt\toInt64(\BigInt\op_Subtraction($v3_1->l0, NULL));
            $v2_1->l0 = $v31;
            $v5->l0 = new US2_US2_1();
            return method6($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5);
    }
}

#45
function closure9($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5, $unitVar) {
    return method6($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5);
}

#46
function closure5($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            $v0_1->f0_0('create_sequential_roller ()');
            break;
        default:
            break;
    }
    $v8 = method4(method3($v1_1, method2($v1_1, new UH1_UH1_0())), new UH0_UH0_1());
    $v10 = method5($v8, function ($arg10_0040) use ($closure7, $v8) {     return closure7($v8, NULL);
 });
    $v11 = new Mut1(NULL);
    $v12 = new Mut1(NULL);
    $v13 = new Mut1(NULL);
    $v15 = new Mut2(new US2_US2_1());
    return function ($arg10_0040_1) use ($closure9, $v0_1, $v10, $v11, $v12, $v13, $v15) {     return closure9($v0_1, $v10, $v11, $v12, $v13, $v15, NULL);
 };
}

#47
function closure3($unitVar, $v0_1) {
    $v3_1 = \Option\defaultArg(\Option\map(method1(NULL), $v0_1), new US0_US0_1());
    return function ($v) use ($closure5, $v3_1) {     return closure5($v3_1, $v);
 };
}

#48
function method8($v0_1, $v1_1, $v2_1, $v3_1) {
    if (\BigInt\compare($v3_1, $v1_1) < 0) {
        $v5 = \BigInt\toUInt64(\BigInt\op_Multiply($v3_1, NULL));
        if (\BigInt\compare($v5, $v3_1) > 0) {
            return method8($v0_1, $v1_1, $v2_1 + 1, $v5);
        } else {
            $v9 = NULL;
            switch ($v0_1->get_Tag())
            {
                case 0:
                    $v0_1->f0_0($v9);
                    break;
                default:
                    break;
            }
            return $v2_1;
        }
    } else {
        $v12 = NULL;
        switch ($v0_1->get_Tag())
        {
            case 0:
                $v0_1->f0_0($v12);
                break;
            default:
                break;
        }
        return $v2_1;
    }
}

#49
function closure77($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure77) {     return closure77(NULL, NULL);
 });
}

#50
function closure76($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure77) {     return closure77(NULL, NULL);
 });
}

#51
function closure75($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure76) {     return closure76(NULL, NULL);
 });
}

#52
function closure74($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure75) {     return closure75(NULL, NULL);
 });
}

#53
function closure73($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure74) {     return closure74(NULL, NULL);
 });
}

#54
function closure72($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure73) {     return closure73(NULL, NULL);
 });
}

#55
function closure71($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure72) {     return closure72(NULL, NULL);
 });
}

#56
function closure70($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure71) {     return closure71(NULL, NULL);
 });
}

#57
function closure69($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure70) {     return closure70(NULL, NULL);
 });
}

#58
function closure68($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure69) {     return closure69(NULL, NULL);
 });
}

#59
function closure67($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure68) {     return closure68(NULL, NULL);
 });
}

#60
function closure66($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure67) {     return closure67(NULL, NULL);
 });
}

#61
function closure65($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure66) {     return closure66(NULL, NULL);
 });
}

#62
function closure64($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure65) {     return closure65(NULL, NULL);
 });
}

#63
function closure63($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure64) {     return closure64(NULL, NULL);
 });
}

#64
function closure62($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure63) {     return closure63(NULL, NULL);
 });
}

#65
function closure61($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure62) {     return closure62(NULL, NULL);
 });
}

#66
function closure60($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure61) {     return closure61(NULL, NULL);
 });
}

#67
function closure59($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure60) {     return closure60(NULL, NULL);
 });
}

#68
function closure58($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure59) {     return closure59(NULL, NULL);
 });
}

#69
function closure57($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure58) {     return closure58(NULL, NULL);
 });
}

#70
function closure56($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure57) {     return closure57(NULL, NULL);
 });
}

#71
function closure55($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure56) {     return closure56(NULL, NULL);
 });
}

#72
function closure54($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure55) {     return closure55(NULL, NULL);
 });
}

#73
function closure53($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure54) {     return closure54(NULL, NULL);
 });
}

#74
function closure52($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure53) {     return closure53(NULL, NULL);
 });
}

#75
function closure51($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure52) {     return closure52(NULL, NULL);
 });
}

#76
function closure50($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure51) {     return closure51(NULL, NULL);
 });
}

#77
function closure49($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure50) {     return closure50(NULL, NULL);
 });
}

#78
function closure48($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure49) {     return closure49(NULL, NULL);
 });
}

#79
function closure47($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure48) {     return closure48(NULL, NULL);
 });
}

#80
function closure46($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure47) {     return closure47(NULL, NULL);
 });
}

#81
function closure45($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure46) {     return closure46(NULL, NULL);
 });
}

#82
function closure44($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure45) {     return closure45(NULL, NULL);
 });
}

#83
function closure43($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure44) {     return closure44(NULL, NULL);
 });
}

#84
function closure42($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure43) {     return closure43(NULL, NULL);
 });
}

#85
function closure41($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure42) {     return closure42(NULL, NULL);
 });
}

#86
function closure40($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure41) {     return closure41(NULL, NULL);
 });
}

#87
function closure39($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure40) {     return closure40(NULL, NULL);
 });
}

#88
function closure38($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure39) {     return closure39(NULL, NULL);
 });
}

#89
function closure37($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure38) {     return closure38(NULL, NULL);
 });
}

#90
function closure36($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure37) {     return closure37(NULL, NULL);
 });
}

#91
function closure35($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure36) {     return closure36(NULL, NULL);
 });
}

#92
function closure34($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure35) {     return closure35(NULL, NULL);
 });
}

#93
function closure33($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure34) {     return closure34(NULL, NULL);
 });
}

#94
function closure32($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure33) {     return closure33(NULL, NULL);
 });
}

#95
function closure31($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure32) {     return closure32(NULL, NULL);
 });
}

#96
function closure30($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure31) {     return closure31(NULL, NULL);
 });
}

#97
function closure29($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure30) {     return closure30(NULL, NULL);
 });
}

#98
function closure28($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure29) {     return closure29(NULL, NULL);
 });
}

#99
function closure27($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure28) {     return closure28(NULL, NULL);
 });
}

#100
function closure26($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure27) {     return closure27(NULL, NULL);
 });
}

#101
function closure25($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure26) {     return closure26(NULL, NULL);
 });
}

#102
function closure24($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure25) {     return closure25(NULL, NULL);
 });
}

#103
function closure23($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure24) {     return closure24(NULL, NULL);
 });
}

#104
function closure22($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure23) {     return closure23(NULL, NULL);
 });
}

#105
function closure21($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure22) {     return closure22(NULL, NULL);
 });
}

#106
function closure20($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure21) {     return closure21(NULL, NULL);
 });
}

#107
function closure19($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure20) {     return closure20(NULL, NULL);
 });
}

#108
function closure18($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure19) {     return closure19(NULL, NULL);
 });
}

#109
function closure17($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure18) {     return closure18(NULL, NULL);
 });
}

#110
function closure16($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure17) {     return closure17(NULL, NULL);
 });
}

#111
function closure15($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure16) {     return closure16(NULL, NULL);
 });
}

#112
function closure14($unitVar, $unitVar_1) {
    return new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure15) {     return closure15(NULL, NULL);
 });
}

#113
function method11($v0_1, $v1_1) {
    switch ($v1_1->get_Tag())
    {
        case 1:
            return new US4_US4_1();
        default:
            if ($v0_1 <= 0) {
                return new US4_US4_0($v1_1->Item1);
            } else {
                return method11($v0_1 - 1, $v1_1->Item2(NULL));
            }
    }
}

#114
function method10($v0_1, $v1_1, $v2_1, $v3_1) {
    if ($v1_1 < 0) {
        $v5 = \BigInt\toUInt64(\BigInt\op_Addition($v3_1, NULL));
        $v6 = NULL;
        switch ($v0_1->get_Tag())
        {
            case 0:
                $v0_1->f0_0($v6);
                break;
            default:
                break;
        }
        return new US3_US3_0($v5, $v2_1);
    } else {
        switch ($v2_1->get_Tag())
        {
            case 0:
                return new US3_US3_1();
            default:
                $v11 = $v2_1->Item2;
                $v10 = $v2_1->Item1;
                if ($v10 > 1) {
                    $v16 = method11($v1_1, new UH2_UH2_0(NULL, function ($arg10_0040) use ($closure14) {                     return closure14(NULL, NULL);
 }));
                    switch ($v16->get_Tag())
                    {
                        case 0:
                            $v20 = $v16->f0_0;
                            break;
                        default:
                            throw new \Exception('Option does not have a value.');
                            break;
                    }
                    $v23 = \BigInt\toUInt64(\BigInt\op_Multiply(\BigInt\toUInt64(\BigInt\fromUInt8($v10 - 1)), $v20));
                    $v24 = NULL;
                    switch ($v0_1->get_Tag())
                    {
                        case 0:
                            $v0_1->f0_0($v24);
                            break;
                        default:
                            break;
                    }
                    return method10($v0_1, $v1_1 - 1, $v11, \BigInt\toUInt64(\BigInt\op_Addition($v3_1, $v23)));
                } else {
                    $v29 = NULL;
                    switch ($v0_1->get_Tag())
                    {
                        case 0:
                            $v0_1->f0_0($v29);
                            break;
                        default:
                            break;
                    }
                    return method10($v0_1, $v1_1 - 1, $v11, $v3_1);
                }
        }
    }
}

#115
function method12($v0_1, $v1_1, $v2_1) {
    if ($v2_1 < $v0_1) {
        return new UH1_UH1_1($v1_1(NULL), method12($v0_1, $v1_1, ($v2_1 + 1)));
    } else {
        return new UH1_UH1_0();
    }
}

#116
function method13($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5) {
    $v6 = $v4_1 + 1;
    if ($v4_1 < $v6) {
        return $method9($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_1($v1_1(NULL), $v5), $v6);
    } else {
        $v12 = method10($v0_1, $v4_1, $v5, NULL);
        if ($v12->get_Tag() == 0) {
            $v13 = $v12->f0_0;
            if (\BigInt\compare($v13, $v3_1) <= 0) {
                return $v13;
            } else {
                if ($v2_1) {
                    return method13($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, method12($v4_1, $v1_1, 0));
                } else {
                    return $method9($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_1($v1_1(NULL), $v5), $v6);
                }
            }
        } else {
            if ($v2_1) {
                return method13($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, method12($v4_1, $v1_1, 0));
            } else {
                return $method9($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_1($v1_1(NULL), $v5), $v6);
            }
        }
    }
}

#117
function method9($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, $v5, $v6) {
    if ($v6 < $v4_1 + 1) {
        return method9($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_1($v1_1(NULL), $v5), $v6 + 1);
    } else {
        $v14 = method10($v0_1, $v4_1, $v5, NULL);
        if ($v14->get_Tag() == 0) {
            $v15 = $v14->f0_0;
            if (\BigInt\compare($v15, $v3_1) <= 0) {
                return $v15;
            } else {
                if ($v2_1) {
                    return method13($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, method12($v4_1, $v1_1, 0));
                } else {
                    return method9($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_1($v1_1(NULL), $v5), $v6 + 1);
                }
            }
        } else {
            if ($v2_1) {
                return method13($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, method12($v4_1, $v1_1, 0));
            } else {
                return method9($v0_1, $v1_1, $v2_1, $v3_1, $v4_1, new UH1_UH1_1($v1_1(NULL), $v5), $v6 + 1);
            }
        }
    }
}

#118
function closure13($v0_1, $v1_1, $v2_1, $v3_1) {
    return method9($v0_1, $v1_1, $v2_1, $v3_1, (\BigInt\equals($v3_1, NULL) ? 1 : method8($v0_1, $v3_1, 0, NULL)) - 1, new UH1_UH1_0(), 0);
}

#119
function closure12($v0_1, $v1_1, $v2_1) {
    return function ($v) use ($closure13, $v0_1, $v1_1, $v2_1) {     return closure13($v0_1, $v1_1, $v2_1, $v);
 };
}

#120
function closure11($v0_1, $v1_1) {
    return function ($v) use ($closure12, $v0_1, $v1_1) {     return closure12($v0_1, $v1_1, $v);
 };
}

#121
function closure10($unitVar, $v0_1) {
    $v3_1 = \Option\defaultArg(\Option\map(method1(NULL), $v0_1), new US0_US0_1());
    return function ($v) use ($closure11, $v3_1) {     return closure11($v3_1, $v);
 };
}

#122
function method14($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return $v1_1;
        default:
            return method14($v0_1->Item2, $v1_1 + 1);
    }
}

#123
function closure80($v0_1, $v1_1, $v2_1) {
    $v10 = method10(\Option\defaultArg(\Option\map(method1(NULL), $v0_1), new US0_US0_1()), method14($v2_1, 0) - 1, $v2_1, NULL);
    if ($v10->get_Tag() == 0) {
        $v11 = $v10->f0_0;
        if (\BigInt\compare($v11, NULL) >= 0 ? \BigInt\compare($v11, $v1_1) <= 0 : false) {
            $v20 = new US4_US4_0($v11);
        } else {
            $v20 = new US4_US4_1();
        }
    } else {
        $v20 = new US4_US4_1();
    }
    switch ($v20->get_Tag())
    {
        case 0:
            return $v20->f0_0;
        default:
            return NULL;
    }
}

#124
function closure79($v0_1, $v1_1) {
    return function ($v) use ($closure80, $v0_1, $v1_1) {     return closure80($v0_1, $v1_1, $v);
 };
}

#125
function closure78($unitVar, $v0_1) {
    return function ($v) use ($closure79, $v0_1) {     return closure79($v0_1, $v);
 };
}

#126
function method40($v0_1, $v1_1) {
    $v2_1 = \BigInt\toInt64(\BigInt\op_Addition($v1_1, NULL));
    $v3_1 = NULL;
    $console->log;
    return new US5_US5_0($v2_1, $v0_1);
}

#127
function method39($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v7 = \BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1));
                $v8 = NULL;
                $console->log;
                return method40($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v7)));
            } else {
                $v11 = NULL;
                $console->log;
                return method40($v4_1, $v1_1);
            }
    }
}

#128
function method38($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method39($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method39($v4_1, $v1_1);
            }
    }
}

#129
function method37($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method38($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method38($v4_1, $v1_1);
            }
    }
}

#130
function method36($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method37($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method37($v4_1, $v1_1);
            }
    }
}

#131
function method35($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method36($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method36($v4_1, $v1_1);
            }
    }
}

#132
function method34($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method35($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method35($v4_1, $v1_1);
            }
    }
}

#133
function method33($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method34($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method34($v4_1, $v1_1);
            }
    }
}

#134
function method32($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method33($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method33($v4_1, $v1_1);
            }
    }
}

#135
function method31($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method32($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method32($v4_1, $v1_1);
            }
    }
}

#136
function method30($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method31($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method31($v4_1, $v1_1);
            }
    }
}

#137
function method29($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method30($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method30($v4_1, $v1_1);
            }
    }
}

#138
function method28($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method29($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method29($v4_1, $v1_1);
            }
    }
}

#139
function method27($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method28($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method28($v4_1, $v1_1);
            }
    }
}

#140
function method26($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method27($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method27($v4_1, $v1_1);
            }
    }
}

#141
function method25($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method26($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method26($v4_1, $v1_1);
            }
    }
}

#142
function method24($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method25($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method25($v4_1, $v1_1);
            }
    }
}

#143
function method23($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method24($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method24($v4_1, $v1_1);
            }
    }
}

#144
function method22($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method23($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method23($v4_1, $v1_1);
            }
    }
}

#145
function method21($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method22($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method22($v4_1, $v1_1);
            }
    }
}

#146
function method20($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method21($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method21($v4_1, $v1_1);
            }
    }
}

#147
function method19($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method20($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method20($v4_1, $v1_1);
            }
    }
}

#148
function method18($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method19($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method19($v4_1, $v1_1);
            }
    }
}

#149
function method17($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method18($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method18($v4_1, $v1_1);
            }
    }
}

#150
function method16($v0_1, $v1_1) {
    switch ($v0_1->get_Tag())
    {
        case 0:
            return new US5_US5_1();
        default:
            $v4_1 = $v0_1->Item2;
            $v3_1 = $v0_1->Item1;
            if ($v3_1 > 1) {
                $v8 = \BigInt\toInt64(\BigInt\op_Multiply(\BigInt\toInt64(\BigInt\fromUInt8($v3_1 - 1)), NULL));
                $v9 = NULL;
                $console->log;
                return method17($v4_1, \BigInt\toInt64(\BigInt\op_Addition($v1_1, $v8)));
            } else {
                $v12 = NULL;
                $console->log;
                return method17($v4_1, $v1_1);
            }
    }
}

#151
function method15($v0_1, $v1_1) {
    if ($v1_1 < 24) {
        $_v3 = NULL;
        $_v3 = 0;
        return method15(new UH1_UH1_1(\Option\value($_v3), $v0_1), $v1_1 + 1);
    } else {
        $v16 = method16($v0_1, NULL);
        if ($v16->get_Tag() == 0) {
            $v17 = $v16->f0_0;
            if (\BigInt\compare($v17, NULL) <= 0) {
                return $v17;
            } else {
                $_v20 = NULL;
                $_v20 = 0;
                $v28 = \Option\value($_v20);
                $_v29 = NULL;
                $_v29 = 0;
                $v35 = \Option\value($_v29);
                $_v36 = NULL;
                $_v36 = 0;
                $v42 = \Option\value($_v36);
                $_v43 = NULL;
                $_v43 = 0;
                $v49 = \Option\value($_v43);
                $_v50 = NULL;
                $_v50 = 0;
                $v56 = \Option\value($_v50);
                $_v57 = NULL;
                $_v57 = 0;
                $v63 = \Option\value($_v57);
                $_v64 = NULL;
                $_v64 = 0;
                $v70 = \Option\value($_v64);
                $_v71 = NULL;
                $_v71 = 0;
                $v77 = \Option\value($_v71);
                $_v78 = NULL;
                $_v78 = 0;
                $v84 = \Option\value($_v78);
                $_v85 = NULL;
                $_v85 = 0;
                $v91 = \Option\value($_v85);
                $_v92 = NULL;
                $_v92 = 0;
                $v98 = \Option\value($_v92);
                $_v99 = NULL;
                $_v99 = 0;
                $v105 = \Option\value($_v99);
                $_v106 = NULL;
                $_v106 = 0;
                $v112 = \Option\value($_v106);
                $_v113 = NULL;
                $_v113 = 0;
                $v119 = \Option\value($_v113);
                $_v120 = NULL;
                $_v120 = 0;
                $v126 = \Option\value($_v120);
                $_v127 = NULL;
                $_v127 = 0;
                $v133 = \Option\value($_v127);
                $_v134 = NULL;
                $_v134 = 0;
                $v140 = \Option\value($_v134);
                $_v141 = NULL;
                $_v141 = 0;
                $v147 = \Option\value($_v141);
                $_v148 = NULL;
                $_v148 = 0;
                $v154 = \Option\value($_v148);
                $_v155 = NULL;
                $_v155 = 0;
                $v161 = \Option\value($_v155);
                $_v162 = NULL;
                $_v162 = 0;
                $v168 = \Option\value($_v162);
                $_v169 = NULL;
                $_v169 = 0;
                $v175 = \Option\value($_v169);
                $_v176 = NULL;
                $_v176 = 0;
                return method15(new UH1_UH1_1($v28, new UH1_UH1_1($v35, new UH1_UH1_1($v42, new UH1_UH1_1($v49, new UH1_UH1_1($v56, new UH1_UH1_1($v63, new UH1_UH1_1($v70, new UH1_UH1_1($v77, new UH1_UH1_1($v84, new UH1_UH1_1($v91, new UH1_UH1_1($v98, new UH1_UH1_1($v105, new UH1_UH1_1($v112, new UH1_UH1_1($v119, new UH1_UH1_1($v126, new UH1_UH1_1($v133, new UH1_UH1_1($v140, new UH1_UH1_1($v147, new UH1_UH1_1($v154, new UH1_UH1_1($v161, new UH1_UH1_1($v168, new UH1_UH1_1($v175, new UH1_UH1_1(\Option\value($_v176), new UH1_UH1_0()))))))))))))))))))))))), 23);
            }
        } else {
            $_v210 = NULL;
            $_v210 = 0;
            $v218 = \Option\value($_v210);
            $_v219 = NULL;
            $_v219 = 0;
            $v225 = \Option\value($_v219);
            $_v226 = NULL;
            $_v226 = 0;
            $v232 = \Option\value($_v226);
            $_v233 = NULL;
            $_v233 = 0;
            $v239 = \Option\value($_v233);
            $_v240 = NULL;
            $_v240 = 0;
            $v246 = \Option\value($_v240);
            $_v247 = NULL;
            $_v247 = 0;
            $v253 = \Option\value($_v247);
            $_v254 = NULL;
            $_v254 = 0;
            $v260 = \Option\value($_v254);
            $_v261 = NULL;
            $_v261 = 0;
            $v267 = \Option\value($_v261);
            $_v268 = NULL;
            $_v268 = 0;
            $v274 = \Option\value($_v268);
            $_v275 = NULL;
            $_v275 = 0;
            $v281 = \Option\value($_v275);
            $_v282 = NULL;
            $_v282 = 0;
            $v288 = \Option\value($_v282);
            $_v289 = NULL;
            $_v289 = 0;
            $v295 = \Option\value($_v289);
            $_v296 = NULL;
            $_v296 = 0;
            $v302 = \Option\value($_v296);
            $_v303 = NULL;
            $_v303 = 0;
            $v309 = \Option\value($_v303);
            $_v310 = NULL;
            $_v310 = 0;
            $v316 = \Option\value($_v310);
            $_v317 = NULL;
            $_v317 = 0;
            $v323 = \Option\value($_v317);
            $_v324 = NULL;
            $_v324 = 0;
            $v330 = \Option\value($_v324);
            $_v331 = NULL;
            $_v331 = 0;
            $v337 = \Option\value($_v331);
            $_v338 = NULL;
            $_v338 = 0;
            $v344 = \Option\value($_v338);
            $_v345 = NULL;
            $_v345 = 0;
            $v351 = \Option\value($_v345);
            $_v352 = NULL;
            $_v352 = 0;
            $v358 = \Option\value($_v352);
            $_v359 = NULL;
            $_v359 = 0;
            $v365 = \Option\value($_v359);
            $_v366 = NULL;
            $_v366 = 0;
            return method15(new UH1_UH1_1($v218, new UH1_UH1_1($v225, new UH1_UH1_1($v232, new UH1_UH1_1($v239, new UH1_UH1_1($v246, new UH1_UH1_1($v253, new UH1_UH1_1($v260, new UH1_UH1_1($v267, new UH1_UH1_1($v274, new UH1_UH1_1($v281, new UH1_UH1_1($v288, new UH1_UH1_1($v295, new UH1_UH1_1($v302, new UH1_UH1_1($v309, new UH1_UH1_1($v316, new UH1_UH1_1($v323, new UH1_UH1_1($v330, new UH1_UH1_1($v337, new UH1_UH1_1($v344, new UH1_UH1_1($v351, new UH1_UH1_1($v358, new UH1_UH1_1($v365, new UH1_UH1_1(\Option\value($_v366), new UH1_UH1_0()))))))))))))))))))))))), 23);
        }
    }
}

#152
function closure81($unitVar, $v0_1) {
    $v1_1 = NULL;
    $console->log;
    $v5 = NULL;
    $console->log;
    return 0;
}

#153
$GLOBALS['v0'] = function ($v) use ($closure0) { return closure0(NULL, $v);
 };

#154
function rotate_numbers($x) {
    return $GLOBALS['v0']($x);
}

#155
$GLOBALS['v1'] = function ($v) use ($closure3) { return closure3(NULL, $v);
 };

#156
function create_sequential_roller($x) {
    return $GLOBALS['v1']($x);
}

#157
$GLOBALS['v2'] = function ($v) use ($closure10) { return closure10(NULL, $v);
 };

#158
function roll_progressively($x) {
    return $GLOBALS['v2']($x);
}

#159
$GLOBALS['v3'] = function ($v) use ($closure78) { return closure78(NULL, $v);
 };

#160
function roll_within_bounds($x) {
    return $GLOBALS['v3']($x);
}

#161
$GLOBALS['v4'] = function ($v) use ($closure81) { return closure81(NULL, $v);
 };

#162
function main($args) {
    return $GLOBALS['v4']($args);
}

