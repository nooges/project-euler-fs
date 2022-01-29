#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

(*
    Power digit sum

    Problem 16

    2**15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

    What is the sum of the digits of the number 2**1000?
*)

string (pown 2I 1000)
|> Seq.sumBy (string >> int)
|> pp
