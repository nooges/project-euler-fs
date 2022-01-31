#!/usr/bin/env -S dotnet fsi

#load "common.fsx"
open Common

seq { 1I .. 100I }
|> Seq.reduce (*)
|> digitSum
|> pp
