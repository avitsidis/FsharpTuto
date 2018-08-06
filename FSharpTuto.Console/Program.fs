// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    //Print text to console
    let name = Environment.UserName
    printfn "Hello %s!" name


    0 // return an integer exit code
