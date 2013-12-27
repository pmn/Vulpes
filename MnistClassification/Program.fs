﻿// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
namespace MnistClassification

module Main =

    open DeepBelief
    open DeepBeliefNet
    open CudaDeepBeliefNet
    open NeuralNet
    open MnistClassification
    open Utils

    [<EntryPoint>]
    let main argv = 
        printfn "%A" (gpuComputeResults props trainingSet testSet 10)
        0 // return an integer exit code
