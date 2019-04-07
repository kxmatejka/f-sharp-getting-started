let rec factorial (x: int): int =
    match x with
    | 0 -> 1
    | n -> n * factorial (n - 1)

let main () =
    printf "Enter value: "
    let value = System.Console.ReadLine() |> int
    printfn "Factorial of %i is %i" value (factorial value)

main()
