#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

let fact n = seq { 1I .. n } |> Seq.reduce (*)
let choose n r = fact n / (fact r * fact (n - r))
choose 40I 20I |> pp
