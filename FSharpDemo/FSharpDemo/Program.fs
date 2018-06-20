// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open BinaryTree
open Others

[<EntryPoint>]
let main argv = 
    //let tree = Node (10, Leaf 5, Leaf 15)
    //printfn "%A" (tree.Add 20).InOrder

    //let l = lazy !1000000
    //printfn "%A" l

    //printfn "%A" (combinations 2 [1; 2; 3])
    for item in permutations [1; 2; 3] do
        printfn "%A" item
    0 // return an integer exit code
