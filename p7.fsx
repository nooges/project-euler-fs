#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

(*
    10001st prime

    Problem 7

    By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

    What is the 10,001st prime number?
*)

let nthPrime n =
    seq { 2L .. 1000000L }
    |> Seq.filter isPrimeL
    |> Seq.tryItem (n - 1)

nthPrime 10001 |> pp
