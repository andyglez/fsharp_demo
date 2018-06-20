module Others

let rec (!) n = 
    match n with
    | 1 -> 1
    | n -> n * !(n - 1)
