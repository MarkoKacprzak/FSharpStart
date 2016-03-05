let choice = 'y'
let name = "Zara Ali"

printfn "Choice: %c" choice
printfn "Name: %s" name

let trueVal = true
printfn "True Value: %b" (trueVal)

let x:int32 = 10
printfn "x: %d" x

let p:float = 15.99
printfn "p: %g" p

let A=60:int
let B=13:int
//A = 0011 1100
//B = 0000 1101
A&&&B 
// = 0000 1100 = 12
A|||B 
// = 0011 1101 = 61
A^^^B
// XOR  = 0011 0001= 49
~~~A 
// -69 1100 0011
A<<<2
// 240  1111 0000
A>>>2 
// 15 0000 1111

//Operator Precedence

//Right: as, when, ;, ->,  :=, ^op, ::, **, |(pattern metch), 
//Left: |, or, ||, &, &&, <op, >op, =, >>>, ~~~, -, +, *, f, ., 
//lot ass: let, fun, function, march, try, if,, , :?>, :?, 
open System

let someint s : int32 =
   let ret=
    if (s=1) then
     100
    elif (s=2) then
     400
    else
     200  
   ret
     
printfn "adas %d" (someint 2)  
    
 
   