#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

let fact n = seq { 1I .. n } |> Seq.reduce (*)
let choose n r = fact n / (fact r * fact (n - r))

seq { 2I .. 100I }
|> Seq.map (fun n ->
    seq { 2I .. n - 1I }
    |> Seq.map (fun r -> choose n r)
    |> Seq.filter (fun a -> a > 1000000I)
    |> Seq.length)
|> Seq.sum
|> pp
