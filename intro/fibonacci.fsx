let rec fibonacci (x: int): int =
    match x with
    | x when x < 2 -> 1
    | x -> fibonacci (x - 1) + fibonacci (x - 2)

let main () =
    printfn "Enter value: "
    let value = System.Console.ReadLine() |> int
    printfn "Fibonacci number of %i is %i" value (fibonacci value)

main()
