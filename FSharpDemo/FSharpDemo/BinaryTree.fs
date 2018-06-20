module BinaryTree

type BinaryTree<'a when 'a : equality and 'a : comparison> =
    | Nil
    | Leaf of 'a
    | Node of 'a * 'a BinaryTree * 'a BinaryTree
    with
        member this.Contains value = 
                match this with
                    | Nil -> false
                    | Leaf v -> v = value
                    | Node(v, _, _) when v = value -> true
                    | Node(v, left, _) when v > value -> left.Contains value
                    | Node(_, _, right) -> right.Contains value
        member this.Add value =
                match this with
                    | Nil -> Leaf value
                    | Leaf v when v = value -> Leaf v
                    | Leaf v when v > value -> Node (v, Leaf value, Nil)
                    | Leaf v when v < value -> Node (v, Nil, Leaf value)
                    | Node(v, left, right) when v = value -> Node(v, left, right)
                    | Node(v, left, right) when v > value -> Node(v, left.Add value, right)
                    | Node(v, left, right) when v < value -> Node(v, left, right.Add value)
                    | tree -> tree
        member this.InOrder =
                match this with
                    | Nil -> []
                    | Leaf v -> [v]
                    | Node(v, l, r) -> l.InOrder@[v]@r.InOrder