namespace Canopy2048

open canopy
open runner
open System
open Game
open Interactions

module Bots =
    let makeMove direction =
            match direction with 
            | 0 -> press up 
            | 1 -> press right 
            | 2 -> press down 
            | _ -> press left

    let runRandomBot = 
        let rec randomMoves() = 
            if won() then 
                printfn "Winner! Finished!"    
            else if lost() then
                printfn "Boo game over"
            else 
                let rnd = System.Random()
                let direction = rnd.Next(0, 3)
                makeMove direction
                randomMoves()        
        randomMoves()