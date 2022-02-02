#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

let hasSameDigits a b =
    let sortDigits x =
        string x |> Seq.sort |> System.String.Concat

    sortDigits a = sortDigits b

positiveNumbers
|> Seq.filter (fun n -> hasSameDigits n (2I * n))
|> Seq.filter (fun n -> hasSameDigits n (3I * n))
|> Seq.filter (fun n -> hasSameDigits n (4I * n))
|> Seq.filter (fun n -> hasSameDigits n (5I * n))
|> Seq.filter (fun n -> hasSameDigits n (6I * n))
|> pp
