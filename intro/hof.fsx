let logger cb a b =
    printfn "a=%i b=%i" a b
    cb a b

let add a b = a + b
let addWithLogger a b = logger add a b

addWithLogger 10 20 |> printfn "%i"
