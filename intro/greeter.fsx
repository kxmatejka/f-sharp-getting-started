let greeter () =
    printf "Type your name: "
    let name = System.Console.ReadLine()
    printfn "Hello: %s!" name

greeter()
