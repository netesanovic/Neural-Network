// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

type NeuralNetwork = 
    {
        top: int list
        network: float array array
        input: float list
        weights: float array array array
        biases: float array array
    }


[<EntryPoint>]
let main argv = 

    let neuralnetwork = 
        {
            top     = [2; 3; 1]
            network = [||]
            input   = [7.0; 15.0]
            weights = [||]
            biases  = [||]
        }

    Console.ReadLine() |> ignore

    0 // return an integer exit code
