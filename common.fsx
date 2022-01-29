// Utility functions commonly used in multiple problems

module Common

let isMultiple a b = b % a = 0
let isMultipleL a b = b % a = 0L
let pp a = printfn "%A" a

let isPrime =
    function
    | 2
    | 3 -> true
    | n when n < 2 || isMultiple 2 n || isMultiple 3 n -> false
    | n ->
        let rec loop =
            function
            | i when i * i >= n -> true
            | i when isMultiple i n || isMultiple (i + 2) n -> false
            | i -> loop (i + 6)

        loop 5

let isPrimeL =
    function
    | 2L
    | 3L -> true
    | n when n < 2L || isMultipleL 2L n || isMultipleL 3L n -> false
    | n ->
        let rec loop =
            function
            | i when i * i >= n -> true
            | i when isMultipleL i n || isMultipleL (i + 2L) n -> false
            | i -> loop (i + 6L)

        loop 5
