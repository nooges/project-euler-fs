#!/usr/bin/env -S dotnet fsi

(*
    Largest palindrome product

    Problem 4

    A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

    Find the largest palindrome made from the product of two 3-digit numbers.
*)

let isPalindrome n =
    let str = n |> string
    let revStr = str |> Seq.toArray |> Array.rev |> System.String
    str = revStr

let searchRange = seq { 999..-1..100 }

(searchRange, searchRange)
||> Seq.allPairs
|> Seq.map (fun (x, y) -> x * y)
|> Seq.map (fun n -> (n, isPalindrome n))
|> Seq.filter (fun (n, b) -> b)
|> Seq.maxBy (fun (n, b) -> n)
|> printfn "%A"
