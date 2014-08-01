
namespace Canopy2048
open System
open NUnit.Framework
open FsUnit
open GreedyBot

module module1 =

    [<TestFixture>]
    type ``Greedy bot Tests`` ()=        
        let state1 = Map<Pos,int>[{ Row = 1; Col = 1 } ,1; { Row = 2; Col = 1 } ,1]
        let state2 = Map<Pos,int>[{ Row = 1; Col = 1 } ,1; { Row = 1; Col = 2 } ,1]

        [<Test>] member test.
            ``should go up or down to collapse two ones in state1``()=  
              let nextMove = getNextMove (state1) in               
                (nextMove = Up || nextMove = Down) |> should equal true

        
        [<Test>] member test.
            ``should go left or right to collapse two ones in state2``()=  
              let nextMove = getNextMove (state1) in               
                (nextMove = Left || nextMove = Right) |> should equal true