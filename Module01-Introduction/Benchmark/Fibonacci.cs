using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Dotnetos.AsyncExpert.Homework.Module01.Benchmark
{
    [DisassemblyDiagnoser(exportCombinedDisassemblyReport: true, printSource: true)]
    [MemoryDiagnoser]
    public class FibonacciCalc
    {
        // HOMEWORK:
        // 1. Write implementations for RecursiveWithMemoization and Iterative solutions
        // 2. Add MemoryDiagnoser to the benchmark
        // 3. Run with release configuration and compare results
        // 4. Open disassembler report and compare machine code
        // 
        // You can use the discussion panel to compare your results with other students

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(Data))]
        public ulong Recursive(ulong n)
        {
            if (n == 1 || n == 2) return 1;
            return Recursive(n - 2) + Recursive(n - 1);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong RecursiveWithMemoization(int n)
        {
            if (n == 1 || n == 2) return 1;

            var cache = new ulong[n + 1];
            cache[1] = 1;
            cache[2] = 1;

            ulong Go(int ni)
            {
                if (cache[ni] != 0) return cache[ni];

                var result = Go(ni - 2) + Go(ni - 1);

                cache[ni] = result;

                return result;
            }

            return Go(n);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong IterativeWithArray(int n)
        {
            if (n == 1 || n == 2) return 1;

            var cache = new ulong[n + 1];
            cache[1] = 1;
            cache[2] = 2;
            var i = 3;

            while (i <= n)
            {
                cache[i] = cache[i - 1] + cache[i - 2];
                i++;
            }

            return cache[n];
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong IterativeWithDictionary(int n)
        {
            if (n == 1 || n == 2) return 1;

            var cache = new Dictionary<int, ulong> { { 1, 1 }, { 2, 1 } };
            var i = 3;

            while (i <= n)
            {
                cache[i] = cache[i - 1] + cache[i - 2];
                i++;
            }

            return cache[n];
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong Iterative(ulong n)
        {
            if (n == 1 || n == 2) return 1;

            ulong current = 1;
            ulong previous = 1;

            var i = 3u;
            while (i <= n)
            {
                ulong next = previous + current;
                previous = current;
                current = next;
                i++;
            }

            return current;
        }

        public IEnumerable<ulong> Data()
        {
            yield return 15;
            yield return 35;
        }
    }
}
