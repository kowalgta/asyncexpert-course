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
        member __.RecursiveMemoized(n: int) =
            let memo n =
                let cache = 
                    Dictionary<int, uint64>()
                cache.Add(1, 1uL)
                cache.Add(2, 1uL)

                let rec go = function
                    | 1 | 2 -> 1uL
                    | n ->
                        let found, r = cache.TryGetValue n
                        if found then r
                        else 
                            let r = go (n - 1) + go (n - 2)
                            cache.Add(n, r)
                            r

                go n

            memo n
                        