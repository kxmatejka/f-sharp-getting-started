let add a b = a + b

let add1add2add3Fn x = add 3 (add 2 (add 1 x))
let add1add2add3Com = add 1 >> add 2 >> add 3

printfn "%i" (add1add2add3Fn 10)
printfn "%i" (add1add2add3Com 10)
