module ArrayMap

// Squaring some numbers:
let numbers = [|0..99|]

let squares = 
   numbers
   |> Array.map (fun n -> n * n)


// Capitalizing some fruit names:
let fruits = [|"apples"; "oranges"; "pears"|]

let capitalFruits =
   fruits
   |> Array.map (fun fruit -> fruit.ToUpper())

// Mapping using a separately defined function:
open System

let InitCap str =
   if String.IsNullOrEmpty str then
      str
   else
      str.[0].ToString().ToUpperInvariant() + str.[1..]

let initCapFruits =
   fruits
   |> Array.map (fun fruit -> InitCap fruit)

// Omitting lambda when input type matches argument:
let initCapFruits2 =
   fruits
   |> Array.map InitCap
