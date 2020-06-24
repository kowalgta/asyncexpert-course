namespace BenchmarkFSharp

open System.Collections.Generic
open BenchmarkDotNet.Running
open BenchmarkDotNet.Attributes

module Benchmarks =
    [<MemoryDiagnoser>]
    [<DisassemblyDiagnoser(exportCombinedDisassemblyReport = true, printSource = true)>]
    type FibonacciCalcFSharp() =
        member __.Data = [ 15; 35 ];

        [<Benchmark>]
        [<ArgumentsSource("Data")>]
        member __.RecursiveMemoized(n: uint64) =
            let memo n =
                let cache = Dictionary<uint64, uint64>()
                cache.Add(1uL, 1uL)
                cache.Add(2uL, 1uL)

                let rec go = function
                    | 1uL | 2uL -> 1uL
                    | n ->
                        let found, r = cache.TryGetValue n
                        if found then r
                        else 
                            let r = go (n - 1uL) + go (n - 2uL)
                            cache.Add(n, r)
                            r

                go n

            memo n
                        