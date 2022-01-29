#!/usr/bin/env -S dotnet fsi

(*
    Smallest multiple

    Problem 5

    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*)

let isMultiple a b = b % a = 0

let isMultipleOfAll range n =
    range |> Seq.forall (fun a -> isMultiple a n)

let f n =
    let range = seq { 3..n }

    let rec loop a =
        match a with
        | a when isMultipleOfAll range a -> a
        | _ -> loop (a + 1)

    loop n

f 20 |> printfn "%A"
