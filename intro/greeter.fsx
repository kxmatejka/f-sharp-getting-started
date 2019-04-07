let greeter () =
    printf "Type your name: "
    System.Console.ReadLine() |> printfn "Hello: %s!"

greeter()
