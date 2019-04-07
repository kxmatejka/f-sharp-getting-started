let rec readUserInput numbers =
    let value = System.Console.ReadLine()
    match value with
    | ":s" -> numbers
    | n -> List.append numbers [n |> int] |> readUserInput

let main () =
    printfn "Write numbers. To calculate sum enter ':s'"
    readUserInput [] |> List.sum |> printfn "Sum: %i"

main()
