let div x y =
   match y with
   | 0 -> None
   | _ -> Some(x/y)

let res : int option = div 20 5
printfn "Result: %A " res
if res.IsSome then
    printfn "Result: %A " res.Value
    
let isHundred = function
   | Some(100) -> true
   | Some(_) | None -> false

printfn "%A" (isHundred (Some(45)))
printfn "%A" (isHundred (Some(100)))
printfn "%A" (isHundred None)

// 