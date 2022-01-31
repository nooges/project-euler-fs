#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

let range = seq { 2..100 }

range
|> Seq.collect (fun a -> range |> Seq.map (fun b -> pown (bigint a) b))
|> Seq.distinct
|> Seq.length
|> pp
