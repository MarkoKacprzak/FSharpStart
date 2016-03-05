// Matching on collection elements
let MatchDemo() =
  let example1 = []
  let example2 = [1]
  let example3 = [99]
  let example4 = [1;2]
  let example5 = [0;1]
  let example6 = [4;2;9]
  let example7 = [99..150]
  let example8 = [1..10]
  let examples = [example1; example2; example3; example4; example5; example6; example7; example8]
  let matchIt e =
     match e with
     | [] -> printfn "That was example1"
     | [1] -> printfn "That was example2"
     | [_] -> printfn "That was example3"
     | [1;_] -> printfn "That was example4"
     | [_;_] -> printfn "That was example5"
     | [4;x;9] -> printfn "That was example 6: the second element is %i" x
     | 1::t -> printfn "That was example7: the rest of the list is %A" t
     | _ as mystery -> printfn "This was the default match: %A" mystery

  examples
  |> List.iter matchIt
MatchDemo()

type Geometry = 
  | Point 
  | Circle of double 
  | Square of double
  | Rectangle of double * double

let PrintCircles() =
  let items = [Point; Point; Circle(3.2); Square(5.0); Rectangle(4.5, 9.2); Circle(1.0)]
  for Circle(r) in items do
     printfn "Circle %f" r
     
PrintCircles()