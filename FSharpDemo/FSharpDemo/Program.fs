// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open BinaryTree

[<EntryPoint>]
let main argv = 
    let tree = Node (10, Leaf 5, Leaf 15)
    printfn "%A" (tree.Add 20).InOrder
    0 // return an integer exit code
