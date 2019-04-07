let rec fibonacci (x: int): int =
    match x with
    | 0 -> 0
    | 1 -> 1
    | n -> fibonacci (n - 1) + fibonacci (n - 2)

let main () =
    printfn "Enter value: "
    let value = System.Console.ReadLine() |> int
    printfn "Fibonacci number of %i is %i" value (fibonacci value)

main()
