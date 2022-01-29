#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

(*
    Summation of primes

    Problem 10

    The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

    Find the sum of all the primes below two million.
*)

seq { 2L .. 2000000L }
|> Seq.filter isPrimeL
|> Seq.sum
|> pp
