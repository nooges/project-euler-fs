#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

let maxDigits = 1000

let findFib d =
    let rec loop i f1 f2 =
        match (f1, f2) with
        | (a, _) when (numDigits a >= d) -> i
        | (_, a) when (numDigits a >= d) -> i + 1
        | _ -> loop (i + 1) f2 (f1 + f2)

    loop 1 1I 1I

findFib maxDigits |> pp
