// Regression test for DevDiv:212424
// "NoInlining attribute not emitted into IL"
module M
[<System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)>]
let getUnit (f : unit -> unit) = f()