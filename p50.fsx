#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

let maxPrime = 999999
let primes = primesUpTo maxPrime

let consectivePrimeSums n =
    primes
    |> Seq.rev
    |> Seq.windowed n
    |> Seq.map Array.sum
    |> Seq.filter (fun s -> s <= maxPrime)
    |> Seq.tryFind isPrimeL

seq { 1000..-1..2 }
|> Seq.map (fun n -> (n, consectivePrimeSums n))
|> Seq.tryFind (fun (n, s) -> s.IsSome)
|> pp
