let printAB a b =
    printfn "printAB: %s %s" a b

// because mathematical functions can accept only one parameter
// function is compiled to

let printCB c =
    let subFunction d =
        printfn "printCB: %s %s" c d
    subFunction

printAB "some" "thing"
printCB "same" "thing"
