let powersOfTwo n = seq { for i in 0 .. n -> pown 2 i } |> Seq.toList