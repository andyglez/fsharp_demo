module Others

open Microsoft.FSharp.Linq

let rec (!) n = 
    match n with
    | 1 -> bigint(1)
    | n -> bigint(n) * !(n - 1)


let rec remove x xs =
    match xs with
    | [] -> []
    | (x'::xs') -> if x = x' then xs' else x'::(remove x xs')

let rec permutations list = 
    seq {   match list with
            | [] -> yield []
            | _ -> for item in list do
                        for perm in permutations (Seq.toList(query {for x in list do
                                                                        where (not (item.Equals(x)))
                                                                        select x})) do yield item::perm }//(List.where (fun x -> not (item.Equals(x))) list) do

let rec combinations k list =
    seq {
        match list with
        | [] | _ when k = 0 -> yield []
        | _  -> for item in list do
                    for comb in combinations (k - 1) (Seq.toList(query {for x in list do
                                                                        where (not (item.Equals(x)))
                                                                        select x})) do yield item::comb }
