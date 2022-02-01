#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

let maxPrime = 999999
let primes = primesUpTo maxPrime

let consectivePrimeSums n =
    primes
    |> Seq.windowed n
    |> Seq.map Array.sum
    |> Seq.filter isPrimeL
    |> Seq.filter (fun p -> p <= maxPrime)

seq { 1000..-1..500 }
|> Seq.map (fun n -> (n, consectivePrimeSums n))
|> Seq.filter (fun (n, s) -> not (Seq.isEmpty s))
|> Seq.map (fun (n, s) -> (n, Seq.max s))
|> Seq.maxBy (fun (n, s) -> n)
|> pp
