let rec factorial (x: int): int =
    match x with
    | x when x < 1 -> 1
    | x -> x * factorial (x - 1)

let main () =
    printf "Enter value: "
    let value = System.Console.ReadLine() |> int
    printfn "Factorial of %i is %i" value (factorial value)

main()
