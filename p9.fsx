#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

let isTriplet a b c = a * a + b * b = c * c

let range = seq { 1..500 }

let hasTriplet a =
    let test b =
        let c = 1000 - a - b
        isTriplet a b c

    range |> Seq.where (fun b -> test b)

range
|> Seq.map (fun a ->
    range
    |> Seq.where (fun b ->
        let c = 1000 - b - a
        isTriplet a b c))
|> Seq.where (fun s -> not (Seq.isEmpty s))
|> pp
