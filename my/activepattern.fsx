type RainbowColor =
  | Red
  | Orange
  | Yellow
  | Green
  | Blue
  | Indigo
  | Violet

let (|Primary|_|) color =
  match color with
  | Red | Green | Blue -> Some Primary
  | _ -> None

let (|ContainsPrimary|_|) cw =
  match cw with
  | (Primary, _, _) 
  | (_, Primary, _) 
  | (_, _, Primary) -> Some ContainsPrimary
  | _ -> None

let PrimaryColorWays =
  [|
     (Red, Orange, Yellow)
     (Violet, Indigo, Orange)
     (Violet, Green, Orange)
     (Violet, Orange, Red)
     (Violet, Violet, Violet)
  |]
  |> Array.choose (fun cw -> match cw with | ContainsPrimary -> Some cw | _ -> None )