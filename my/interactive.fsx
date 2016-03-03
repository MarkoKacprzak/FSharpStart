open System
let lastDays years=
    [|
        for i in 1..12 do
            let firstDay = DateTime(years, i, 1)
            let lastDay = firstDay.AddDays(float(DateTime.DaysInMonth(years, i)-1))
            yield lastDay.Date
    |]
lastDays 2014