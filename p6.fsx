#!/usr/bin/env -S dotnet fsi
#load "common.fsx"
open Common

let square n = n * n

let diffSums n =
    let range = seq { 1..n }
    let squareOfSum = range |> Seq.sum |> square
    let sumOfSquares = range |> Seq.map square |> Seq.sum
    squareOfSum - sumOfSquares

diffSums 100 |> pp
