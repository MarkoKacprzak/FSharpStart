//verbatim string
open System
// Using a verbatim string
let xmldata = @"<book author=""Lewis, C.S"" title=""Narnia"">"
printfn "%s" xmldata

//string operation

// CONCAT

// Signature:
//String.concat : string -> seq<string> -> string
// Usage:
// String.concat sep strings
// sep - Ciąg separatora dodaje się między ciągami sekwencji wejściowych.
// strings seq<string> - Sekwencja ciągów złączyć.
let strings = [ "tomatoes"; "bananas"; "apples" ]
let fullString = String.concat ", " strings
printfn "%s" fullString

// COLLECT

// Signature:
// String.collect : (char -> string) -> string -> string
// Usage:
// String.collect mapping str
// mapping char -> string  - Funkcja do produkcji w ciągu każdego znaku ciągu wejściowego.
// str - ciag wejsciowy
let spaceOut inputString =
     String.collect (fun c -> sprintf "%c " c) inputString
printfn "%s" (spaceOut "Hello World!")

