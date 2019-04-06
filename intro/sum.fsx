let rec readUserInput numbers =
    let value = System.Console.ReadLine()
    if value = ":s" then numbers
    else readUserInput (List.append numbers [value |> int])

let main () =
    printfn "Write numbers. To calculate sum enter ':s'"
    let numbers = readUserInput []
    printfn "Sum: %i" (List.sum numbers)

main()
