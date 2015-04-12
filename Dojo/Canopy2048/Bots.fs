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

    let gameEnded = 
        if won() then 
            printfn "Winner! Finished!"   
            true
        else if lost() then
            printfn "Boo game over"
            true
        else 
            false

//    let runRandomBot = 
//        let rec randomMoves() = 
//            if not gameEnded  then              
//                let rnd = System.Random()
//                let direction = rnd.Next(0, 3)
//                makeMove direction
//                randomMoves()        
//        randomMoves()

    let runGreedyBot =         
        let rec greedyMoves() = 
            if not gameEnded then 
                let curstate = state() 
                let afterup = execute curstate Up, 0
                let afterright = execute curstate Right, 1
                let afterdown = execute curstate Down, 2
                let afterleft = execute curstate Left, 3
                let greedyMove = [afterup; afterright; afterdown; afterleft] |> List.maxBy fst 
                let newState = (snd (fst greedyMove))
                if newState = curstate then 
                    let rnd = System.Random()
                    let direction = rnd.Next(0, 3)
                    makeMove direction
                else 
                    let greedyDirection = snd greedyMove in
                    makeMove greedyDirection                    
                greedyMoves()
        greedyMoves()