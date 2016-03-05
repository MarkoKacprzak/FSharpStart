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

// ITER

// Signature:
// String.iter : (char -> unit) -> string -> unit
// Usage:
// String.iter action str
// action char -> unit - Funkcja stosowane do każdego znaku ciągu.
// str - ciąg wejsciowy
open System
let testLetter d=
    if (Char.IsDigit(d)) then
      printfn "%c in string is digit" d
String.iter testLetter "as2da1d"

// ITERI

// Signature:
// String.iteri : (int -> char -> unit) -> string -> unit
// Usage:
// String.iteri action str
// action int -> char -> unit - Funkcja stosuje się do każdego znaku i indeks ciągu.
// str - ciąg wejsciowy
let enumerateCharacters inputString = 
    String.iteri (fun i c -> printfn "%d %c" i c) inputString
enumerateCharacters "TIME"
enumerateCharacters "SPACE"

// LENGTH

// Signature:
// String.length : string -> int
// Usage:
// String.length str
// str - ciąg wejściowy
String.length "asdaD"

// MAP

// Signature:
// String.map : (char -> char) -> string -> string
// Usage:
// String.map mapping str
// mapping char -> char - Funkcja stosuje do ciągu znaków.
// str - ciąg wejściowy

let rot13 c =
    let upperZero = int 'A' - 1
    let lowerZero = int 'a' - 1
    if System.Char.IsLetter(c) then
        if System.Char.IsUpper(c) then
            char (((int c + 13 - upperZero) % 26) + upperZero)
        else
            char (((int c + 13 - lowerZero) % 26) + lowerZero)
    else c
let test = "The quick sly fox jumped over the lazy brown dog."
let codec= "Gur dhvpx fyl sbk whzcrq bire gur ynml oebja qbt."
printfn "%s" test
printfn "%s" <| (String.map rot13 test)
printfn "%s" <| (String.map rot13 codec)

// MAPI

// Signature:
// String.mapi : (int -> char -> char) -> string -> string
// Usage:
// String.mapi mapping str
// mapping int -> char -> char - Funkcja stosuje się do każdego znaku i indeks ciągu.
// str - Ciąg wejściowy
let replaceNth n newChar inputString =
    let result = String.mapi (fun i c -> if i = n then newChar else c) inputString
    printfn "%s" result
    result
printfn "MASK"
"MASK" |> replaceNth 0 'B'
|> replaceNth 3 'H'
|> replaceNth 2 'T'
|> replaceNth 1 'O'
|> replaceNth 0 'M'
|> replaceNth 1 'A'
|> replaceNth 2 'S'
|> replaceNth 3 'K'

// REPLICATE

// Signature:
// String.replicate : int -> string -> string
// Usage:
// String.replicate count str
// count int - Liczba kopii ciąg wejściowy zostanie skopiowana.
// str - Ciąg wejściowy
printfn "%s" <| String.replicate 10 "XO"
