let numbers = [| 0..99 |]
let squeres =  numbers |> Array.map ( fun n -> n * n)
let name = [| "Mark"
              "KatE" |]
let upperName = name |> Array.map ( fun str -> str.ToUpper() )

open System
let InitCap str = 
    if String.IsNullOrEmpty str then
        str
    else
        str.[0].ToString().ToUpperInvariant() + str.[1..].ToLower()
let initCapName = 
    upperName |> Array.map InitCap
    
