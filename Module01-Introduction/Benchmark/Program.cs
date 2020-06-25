using System;
using System.Collections.Generic;
using System.Reflection;
using BenchmarkDotNet.Running;
using BenchmarkFSharp;

namespace Dotnetos.AsyncExpert.Homework.Module01.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblies =
                new[] { Assembly.GetExecutingAssembly(), Assembly.GetAssembly(typeof(Benchmarks.FibonacciCalcFSharp)) };

            BenchmarkSwitcher.FromAssemblies(assemblies).Run(args);
        }
    }
}
