let games = ["God Of War"; "Mario"; "Resident Evil"]

let printArrayNames (names: list<string>) =
    for name in names do
        printfn $"{name}"

// games |> Seq.map (fun x -> printfn x)

printArrayNames games