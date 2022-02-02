#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

let textToTriangle (s: string) =
    s.Split "\n"
    |> Array.map (fun l -> l.Split " " |> Array.map int)

let triangle =
    System.IO.File.ReadAllText("p067_triangle.txt")
    |> textToTriangle

let combine a (b: int []) =
    let bmax = b |> Array.windowed 2 |> Array.map Array.max
    Array.map2 (+) a bmax

let maxTriangleSum t =
    t |> Array.reduceBack combine |> Array.sum

maxTriangleSum triangle |> pp
