let rec factorial (x: int): int =
    if x < 1 then 1
    else x * factorial (x - 1)

let main () =
    printf "Enter value: "
    let value = System.Console.ReadLine() |> int
    printfn "Factorial of %i is %i" value (factorial value)

main()
