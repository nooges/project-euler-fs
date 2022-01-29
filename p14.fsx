#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

(*
    Longest Collatz sequence

    Problem 14

    The following iterative sequence is defined for the set of positive integers:

    n → n/2 (n is even)
    n → 3n + 1 (n is odd)

    Using the rule above and starting with 13, we generate the following sequence:

    13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

    Which starting number, under one million, produces the longest chain?

    NOTE: Once the chain starts the terms are allowed to go above one million.
*)

let rec collatzLength acc =
    function
    | 1L -> acc
    | n when isMultipleL 2L n -> memCollatzLength (acc + 1L) (n / 2L)
    | n -> 1L + memCollatzLength (acc + 1L) (3L * n + 1L)

and memCollatzLength = memoize collatzLength

memCollatzLength -1L 13L |> pp

seq { 1L .. 999999L }
|> Seq.maxBy (memCollatzLength -1L)
|> pp
