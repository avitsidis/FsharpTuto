﻿// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    //Print text to console
    let name = Environment.UserName
    printfn "Hello %s!" name

    //Define functions
    let square x = x * x //type inference. As we are using int below it is a int -> int function
    let sumOfSquare i = i |> List.map square |> List.sum

    //Ranges
    let lastItem aList = aList |> List.rev |> List.head // list a simple linked list in f#. this is not performant
    let range1_10 = [1..10] // same as [1; 2;3; ...
    let range0_10 = 0 :: range1_10 // append 0
    let _range0_20 = range1_10 @ [11..20] // concat 2 list
    let sumOfSquareRange0_100 = sumOfSquare range0_10
    printfn "Sum of Squares(%d->%d)=%d" range1_10.Head (lastItem range1_10) sumOfSquareRange0_100

    0 // return an integer exit code
