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

let files = System.IO.Directory.EnumerateFiles(@"c:\")
            |> Array.ofSeq
