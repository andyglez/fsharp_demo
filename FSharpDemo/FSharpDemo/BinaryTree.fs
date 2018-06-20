module BinaryTree

type BinaryTree<'a when 'a : equality and 'a : comparison>=
    | Leaf of 'a
    | Node of 'a * 'a BinaryTree * 'a BinaryTree
    with
        member this.Contains value = 
                match this with
                    | Leaf v -> v = value
                    | Node(v, _, _) when v = value -> true
                    | Node(v, left, _) when v > value -> left.Contains(value)
                    | Node(_, _, right) -> right.Contains(value)