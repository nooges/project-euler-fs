#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

let reverseNum n =
    string n
    |> Seq.rev
    |> System.String.Concat
    |> (fun n -> bigint.Parse(n))

let isPalindrome n = n = reverseNum n

let isLychrel n =
    let rec loop count a =
        match count with
        | 50 -> true
        | _ when isPalindrome a -> false
        | _ -> loop (count + 1) (a + reverseNum a)

    loop 0 (n + reverseNum n)

seq { 1I .. 10000I }
|> Seq.filter isLychrel
|> Seq.length
|> pp
