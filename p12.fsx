#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

let triangleNum n = (n * n + n + 1I) / 2I

let divisors n =
    let sq = float n |> sqrt |> bigint |> (+) 1I

    let rec loop divisors d =
        match d with
        | _ when d = sq -> divisors
        | _ when n % d = 0I -> loop (d :: n / d :: divisors) (d + 1I)
        | _ -> loop divisors (d + 1I)

    loop [ 1I; n ] 2I |> List.distinct

positiveNumbers
|> Seq.map triangleNum
|> Seq.map divisors
|> Seq.find (fun n -> List.length n > 500)
|> List.max
|> pp
