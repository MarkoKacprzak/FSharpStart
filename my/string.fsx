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

// EXISTS

// Signature:
// String.exists : (char -> bool) -> string -> bool
// Usage:
// String.exists predicate str
// predicate char -> bool - Funkcja testowania każdego znaku ciągu.
// str - Ciąg wejściowy
let containsUppercase string1 =
    if (String.exists (fun c -> System.Char.IsUpper(c)) string1) then
        printfn "The string \"%s\" contains uppercase characters." string1
    else
        printfn "The string \"%s\" does not contain uppercase characters." string1
containsUppercase "Hello World!"
containsUppercase "no"

// FORALL

// Signature:
// String.forall : (char -> bool) -> string -> bool
// Usage:
// String.forall predicate string
// prediate char -> bool Funkcja testowania każdego znaku ciągu.
// str - Ciąg wejściowy.
let isWholeNumber string1 =
    if (String.forall (fun c -> System.Char.IsDigit(c)) string1) then
        printfn "The string \"%s\" is a whole number." string1
    else
        printfn "The string \"%s\" is not a valid whole number." string1
isWholeNumber "8005"
isWholeNumber "51a231"

// INIT

// Signature:
// String.init : int -> (int -> string) -> string
// Usage:
// String.init count initializer
// count - Liczba ciągów zainicjować.
// initializer  int -> string - Funkcja indeks i produkują ciąg może być łączone z innymi.
let string1 = String.init 10 (fun i -> i.ToString())
printfn "%s" string1
let string2 = String.init 26 (fun i ->
    sprintf "%c" (char (i + int 'A')))
printfn "%s" string2

open System
let stringwq="asd"
let first=stringwq.[0]
let char1=char first
let isNumer=Char.IsDigit(char1)
printfn "First from string %s is number: %b" stringwq isNumer

