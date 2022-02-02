#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

bigint.ModPow(2I, 7830457I, 10000000000I)
|> (*) 28433I
|> (+) 1I
|> (fun n -> n % 10000000000I)
|> pp
