// Learn more about F# at http://fsharp.org

open System

let x = Console.ReadLine()

if(x="a") then printf "This is the letter A"
else printf "IDK what letter this is"

Console.ReadKey() |> ignore 