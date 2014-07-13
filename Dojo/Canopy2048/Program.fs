﻿(*
The goal of this dojo is to learn the basics of
the F# Canopy web testing framework, written
by Chris Holt (www.twitter.com/lefthandedgoat),
using it to drive the game "2048".

The dojo is setup as as series of tasks,
embedded in this file. It starts with simple
examples using Canopy to interact with the 
game web page, and progressively builds up
to writing an automated bot to play the game.

Have fun! Any feedback is highly appreciated,
either on the GitHub repository itself:
https://github.com/c4fsharp/Dojo-Canopy-2048
or via Twitter on @c4fsharp.

And if you enjoy it, feel free to tweet about it,
using the hashtag #fsharp! 
*)


(*
Task 0: play a game of 2048.
If you have never seen it before, run it here:
http://gabrielecirulli.github.io/2048/

Also, the documentation for Canopy is here:
http://lefthandedgoat.github.io/canopy/actions.html
*)

namespace Canopy2048

open canopy
open runner
open System
open Game
open Interactions
open Bots

module program = 

    "starting a game of 2048" &&& fun _ ->

        printfn "Game started."
            
        (*
        Task 1: start your browser.
        depending on what browser you prefer, 
        you may have to install a browser driver
        on your machine.
        *)

        canopy.configuration.chromeDir <- "/usr/local/Cellar/chromedriver/2.9/bin"
        start chrome
        (*
        Task 2: open the game url.
        *)

        url "http://gabrielecirulli.github.io/2048"
        
        (*
        Task 3: play up, left, down, right.
        *)
    
        press up
        press left
        press down
        press right
        let score = (element ".score-container").Text

        let x = 1
        (*
        Task 4: retrieve the score.
        Check the page and look for the 
        appropriate css tag.
        *)



        (*
        Task 5: play a random game.
        Write a bot that will randomly play
        up, left, down or right at each turn.
        A loop based on recursion is probably 
        a good way to go!
        *)



        (*
        Task 6: terminate!
        Improve your bot - it would be nice if
        the bot stopped playing when the game
        is either lost or won!
        The module Interactions contains 2 handy
        functions that will identify these 2
        situations, lost () and won ().
        *)



        (*
        Task 7: gimme some brains!
        Let's give the bot a minimum of brains.
        Instead of playing randomly, at each
        turn, let's analyze each of the 4 possible
        moves, and pick the move that gives you
        the best one-shot score.
        The module Interactions contains a function
        that will extract the State of the game 
        from the page; it is represented as a Map,
        containing non-empty cells. 
        The keys are of type Pos, of the form 
        { Row = 1; Column = 2 }, the values are the
        integer number in the cell.
        The module Game contains a function execute,
        which takes in a State and a Move, and
        returns a tuple:
        * the score increase of the move,
        * the State after the move.
        *)



        (*
        Task 8: go for it!
        Now that you have a dumb bot, your turn
        to experiment and see if you can make that bot
        smarter!
        *)



        // Just to make sure the test function
        // ends properly.
        printfn "Game ended."
        ignore ()


    //run the "test", i.e. play a game
    run()

    printfn "Press [enter] to exit."
    System.Console.ReadLine() |> ignore

    quit()