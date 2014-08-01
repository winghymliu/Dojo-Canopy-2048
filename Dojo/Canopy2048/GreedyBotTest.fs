
namespace Canopy2048
open System
open NUnit.Framework
open FsUnit
open GreedyBot

module module1 =

    [<TestFixture>]
    type ``Greedy bot Tests`` ()=        
        let posA = { Row = 1; Col = 1 } 
        let posB = { Row = 2; Col = 1 }
     
        let state1 = Map<Pos,int>[posA,1; posB,1]
        [<Test>] member test.
            ``should go up to collapse two ones in state1``()=  
              let nextMove = getNextMove (state1) in               
                nextMove |> should equal Up
