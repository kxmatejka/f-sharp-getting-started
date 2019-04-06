let rec fibonacci (x: int): int =
    if x < 2 then 1
    else fibonacci (x - 1) + fibonacci (x - 2)

let main () =
    printfn "Enter value: "
    let value = System.Console.ReadLine() |> int
    printfn "Fibonacci number of %i is %i" value (fibonacci value)

main()
