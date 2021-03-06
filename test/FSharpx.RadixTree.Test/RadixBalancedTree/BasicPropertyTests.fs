module FSharpx.RadixTree.Test.RadixBalancedTree.``Basic properties``

open Xunit
open FsUnit.Xunit
open FSharpx.RadixTree

[<Fact>]
let ``Has a default index block size of 5 bits``() =
    RadixBalancedTree.empty<int>
    |> RadixBalancedTree.radixBits |> should equal 5

[<Fact>]
let ``Default index block size can be overridden``() =
    RadixBalancedTree.emptyWithRadixBits<int> 1
    |> RadixBalancedTree.radixBits |> should equal 1

[<Fact>]
let ``The radix can be requested``() =
    RadixBalancedTree.empty |> RadixBalancedTree.radix |> should equal 32
    RadixBalancedTree.emptyWithRadixBits 1 |> RadixBalancedTree.radix |> should equal 2

[<Fact>]
let ``Empty tree has length 0``() =
    RadixBalancedTree.empty
    |> RadixBalancedTree.length |> should equal 0<items>

[<Fact>]
let ``Empty tree has depth 0``() =
    RadixBalancedTree.empty
    |> RadixBalancedTree.depth |> should equal 0<lvl>

[<Fact>]
let ``Empty tree has no root node``() =
    RadixBalancedTree.empty
    |> RadixBalancedTree.root |> isAnEmptyNode |> should be True

[<Fact>]
let ``Start and end index of an empty tree are 0``() =
    let t = RadixBalancedTree.empty

    RadixBalancedTree.startIndex t |> should equal 0<pos>
    RadixBalancedTree.endIndex t |> should equal 0<pos>
