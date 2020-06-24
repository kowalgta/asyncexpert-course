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

        private Dictionary<ulong, ulong> _memoizedData = new Dictionary<ulong, ulong>();

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong RecursiveWithMemoization(ulong n)
        {
            if (n == 1 || n == 2) return 1;
            
            if (_memoizedData.TryGetValue(n, out ulong r))
                return r;
            
            var result = RecursiveWithMemoization(n - 2) + RecursiveWithMemoization(n - 1);

            _memoizedData.Add(n, result);

            return result;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong IterativeDictionary(ulong n)
        {
            if (n == 1 || n == 2) return 1;

            var cache = new Dictionary<ulong, ulong> { { 1, 1 }, { 2, 1 } };
            var i = 3u;

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
