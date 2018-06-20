// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open BinaryTree
open Others

[<EntryPoint>]
let main argv = 
    let tree = Node (10, Leaf 5, Leaf 15)
    printfn "%A" (tree.Add 20).InOrder

    let l = lazy !1000000
    printfn "%A" l

    printfn "%A" (permutations [1; 2; 3])
    0 // return an integer exit code
