// WAYS OF CREATING LISTS:

// a Using list literals.
// b Using cons (::) operator.
// c Using the List.init method of List module.
// d Using some syntactic constructs called List Comprehensions.
//      range [x..y] or  generator [ for a in 1..10 do yield (a) ]
// a)
let list1 = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
// b)
let list2 = 1::2::3::4::5::6::7::8::9::10::[]
// c)
let list3 = List.init 10 ( fun a -> a + 1 )
// d)
let list4= [1..10]

// HEAD, EMPTY, ISEMPTY, ITEM, LENGHT, TAIL

// list4.Head [0] Tail [1..10]
let listofsum = List.append  [ list4.Head ] list4.Tail 
listofsum = list3
List.empty.IsEmpty
List.empty<int>.Length
listofsum.Item 2

// OPERATION ON LIST 
//a append, avarage, avarageby, choose, chunkBySize
//b collect, compareWith, concat, Cons, Contains, countBy
//c distinct, distinctBy, exactlyOne, except, exists, exists2, 
//d filter, find, findBack, findIndex, findIndexBack, fold, fold2, foldBack, foldBack2, forall, forall2
//e groupBy, indexed, init, iter, iter2, iteri, iteri2
//f last, map, map2, map3, mapFold, mapFoldBack, mapi, mapi2, max, maxBy, min, minBy
//g ofArray, ofSeq
//h pairwise, partition, permute, pick
//i reduce, reduceBack, replicate, rev
//j scan, scanBack, singleton, skip, skipWhile, sort, sortBy, sortByDescending, 
//k sortDescending, sortWith, splitAt, splitInto, sum, sumBy
//l take, takeWhile, toArray, toSeq, truncate, tryFind, tryFindBack
//m tryFindIndex, tryFindIndexBack, tryHead, tryItem, tryLast, tryPick
//n unfold, unzip, unzip3 
//a)
List.chunkBySize 3 listofsum
let av=List.mapi ( fun i s ->  (float s)  ) listofsum
List.average av.Tail
List.averageBy ( fun s -> s / 2.0 ) av.Tail 

let listWords = [ "and"; "Rome"; "Bob"; "apple"; "1ebra" ]
let isCapitalized (string1:string) = System.Char.IsUpper string1.[0]
let isNumber (string2:string) = System.Char.IsNumber string2.[0]
let results = List.choose (fun elem ->
    match elem with
    | str when isCapitalized str -> Some(str + "'s")
    | str when isNumber str -> Some("N" + str)
    | _ -> None) listWords
printfn "%A" results

List.init 36 (fun s -> "b") |> List.iter (fun elem -> printf "%s " elem) 
// b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b b
//b collect, compareWith, concat, Cons, Contains, countBy
List.collect

let collectList = List.collect (fun x -> [for i in 1..3 -> x * i]) list1
printfn "%A" collectList

let resultCompare = List.compareWith (fun x y -> 0 ) list1 collectList

let sequence1 =  [ 1 .. 10 ]
let sequence2 =  [ 10 .. -1 .. 1 ]

// Compare two sequences element by element.
let compareResult1 = List.compareWith (fun elem1 elem2 ->
     if elem1 > elem2 then 1
     elif elem1 < elem2 then -1
               else 0) 
let res = compareResult1 sequence1 sequence2

match res with
| 1 -> printfn "Sequence1 is greater than sequence2."
| -1 -> printfn "Sequence1 is less than sequence2."
| 0 -> printfn "Sequence1 is equal to sequence2."
| _ -> failwith("Invalid comparison result.")

// if cmpareWith return !=0 during comparison - return it ale return 1 if List1.leght>List2.lenght ale -1 < and 0 if lenght is equal
// Compare two sequences element by element.
let compareSequences = List.compareWith (fun elem1 elem2 -> if elem1 > elem2 then 0 elif elem1 < elem2 then 0 else 0) sequence1 sequence2

let listResult = List.concat [ [1; 2; 3]; [4; 5; 6]; [7; 8; 9] ]

List.Cons (listResult.Head, listResult.Tail)
List.contains 15 listResult
List.countBy (fun f-> if f>5 then 1 else 2) listResult
//C C C C C C C C C C C C C C C C C C C C C C C C C C C C C C C C C C C C 
//c distinct, distinctBy, exactlyOne, except, exists, exists2, 
List.init 36 (fun s -> "C") |> List.iter (fun elem -> printf "%s " elem) 
List.distinct (List.append listResult listResult)
List.distinctBy (fun d -> if d>5 then 1 else 2 ) listResult
List.exactlyOne [ listResult.[0] ]
List.except  listResult.[0..4] listResult
List.exists (fun w -> w>5) listResult
List.exists2 (fun x y -> x=y ) listResult.[1..4] listResult.[2..5]
//
//D D D D D D D D D D D D D D D D D D D D D D D D D D D D D D D D D D D D 
//d filter, find, findBack, findIndex, findIndexBack, fold, fold2, foldBack, foldBack2, forall, forall2
List.init 36 (fun s -> "D") |> List.iter (fun elem -> printf "%s " elem) 

//  ::::::::::: :::::::::: :::::::: ::::::::::: 
//     :+:     :+:       :+:    :+:    :+:      
//    +:+     +:+       +:+           +:+       
//   +#+     +#++:++#  +#++:++#++    +#+        
//  +#+     +#+              +#+    +#+         
// #+#     #+#       #+#    #+#    #+#          
//###     ########## ########     ###           

let test =
  [("Andy", ["d"; "a"; "d"; "c"; "b"; "d"; "c"; "a"; "a"; "c"; "a"; "d"; "a"; "a"; "d"; "e"]);
   ("Harry", ["b"; "d"; "c"; "b"; "c"; "b"; "a"; "a"; "d"; "b"; "d"; "d"; "a"; "c"; "b"; "e"]); ]

let answerKey = ["b"; "a"; "a"; "c"; "d"; "d"; "c"; "a"; "a"; "d"; "a"; "d"; "a"; "a"; "d"; "e"];

let score answerKey answers =
    List.zip answerKey answers
    |> List.sumBy (fun (key, answer) ->
        if key = answer then 1 else 0)

let resultsExam =
    test
    |> List.map (fun (name, answers) ->
        name, score answerKey answers)

let scores resultsExam corr = 
    resultsExam
    |> List.map ( 
        fun (name, score) -> 
            (name, List.fold2 (
                fun s rhs lhs ->  
                    match s with
                    | (good, wrong) when rhs=lhs -> ( good + 1 , wrong) 
                    | (good, wrong) -> ( good, wrong + 1)
                                ) (0, 0) score corr
            ) 
        )
        
let result2=scores test answerKey

let show scorelist = 
 scorelist
 |> List.iter 
    ( fun i -> 
         match i with
         | (name, score) -> 
            match score with
            | (good, wrong) ->
                    printf "%s correct: %d wrong: %d \r\n" 
                     name
                     good 
                     wrong
     )
          
show (scores test answerKey)
