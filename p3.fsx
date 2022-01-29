#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

(*
    Largest prime factor

    Problem 3

    The prime factors of 13195 are 5, 7, 13 and 29.

    What is the largest prime factor of the number 600851475143 ?
*)

let primesUpTo n = seq { 2L .. n } |> Seq.filter isPrimeL

let primeFactors n =
    primesUpTo (float n |> sqrt |> int64)
    |> Seq.filter (fun x -> isMultipleL x n)

primeFactors 600851475143L |> Seq.max |> pp
