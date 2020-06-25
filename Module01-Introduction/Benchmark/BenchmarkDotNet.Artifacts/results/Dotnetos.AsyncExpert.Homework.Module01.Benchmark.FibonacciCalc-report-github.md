``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.329 (2004/?/20H1)
Intel Core i7-7920HQ CPU 3.10GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


```
|                   Method |  n |             Mean |          Error |         StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|------------------------- |--- |-----------------:|---------------:|---------------:|------:|-------:|------:|------:|----------:|----------:|
|                **Recursive** | **15** |      **2,820.88 ns** |      **55.594 ns** |      **52.003 ns** | **1.000** |      **-** |     **-** |     **-** |         **-** |      **76 B** |
| RecursiveWithMemoization | 15 |         68.09 ns |       0.821 ns |       0.768 ns | 0.024 | 0.0362 |     - |     - |     152 B |     233 B |
|       IterativeWithArray | 15 |         28.99 ns |       0.356 ns |       0.333 ns | 0.010 | 0.0363 |     - |     - |     152 B |     164 B |
|  IterativeWithDictionary | 15 |        531.10 ns |       4.077 ns |       3.814 ns | 0.188 | 0.2346 |     - |     - |     984 B |     997 B |
|                Iterative | 15 |         13.35 ns |       0.240 ns |       0.200 ns | 0.005 |      - |     - |     - |         - |      68 B |
|                          |    |                  |                |                |       |        |       |       |           |           |
|                **Recursive** | **35** | **42,905,579.44 ns** | **787,834.553 ns** | **736,940.930 ns** | **1.000** |      **-** |     **-** |     **-** |         **-** |      **76 B** |
| RecursiveWithMemoization | 35 |        182.99 ns |       1.576 ns |       1.316 ns | 0.000 | 0.0744 |     - |     - |     312 B |     233 B |
|       IterativeWithArray | 35 |         66.02 ns |       0.986 ns |       0.874 ns | 0.000 | 0.0745 |     - |     - |     312 B |     164 B |
|  IterativeWithDictionary | 35 |      1,219.41 ns |      22.073 ns |      33.038 ns | 0.000 | 0.4940 |     - |     - |    2072 B |     997 B |
|                Iterative | 35 |         34.95 ns |       0.497 ns |       0.415 ns | 0.000 |      - |     - |     - |         - |      68 B |
