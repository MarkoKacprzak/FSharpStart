open System
let lastDays years=
    [|
        for i in 1..12 do
            let firstDay = DateTime(years, i, 1)
            let lastDay = firstDay.AddDays(float(DateTime.DaysInMonth(years, i)-1))
            yield lastDay.Date
    |]
lastDays 2014

let initializeArray = Array.create 100 1.1

let emptyArray: string[] = Array.zeroCreate 20

let lastDay2 year =
    Array.init 12 ( fun i ->
        let month = i + 1
        let firstDay = new DateTime(year,month,1)
        let lastDay = firstDay.AddDays(float(DateTime.DaysInMonth(year,month)-1))
        lastDay
    )
    
let a=lastDay2 2011


open System
let is_numeric a = fst (System.Double.TryParse(a))
  
let InitCap str = 
    if String.IsNullOrEmpty str then
        str.[0].ToString().ToUpperInvariant()
    else
        str.[0].ToString().ToUpperInvariant() 

let CheckNr er =
    if is_numeric er then
        true
    else
        false
let ss=InitCap "12asdas"
let b=CheckNr ss
if b then
    printf "ok"
printf "nook"

let files = System.IO.Directory.EnumerateDirectories(@"C:\mygit\FSharpStart")
            |> Array.ofSeq
            |> Array.map( fun s -> s.Replace("C:\mygit\FSharpStart\\",""))
            |> Array.iter( fun folder -> 
                let ss=InitCap folder
                let b=CheckNr ss
                if b then 
                    System.IO.Directory.Move(String.Format("C:\mygit\FSharpStart\\{0}",folder), String.Format("C:\mygit\FSharpStart\m{0}",folder) )
                printf "Nie pasuje")

