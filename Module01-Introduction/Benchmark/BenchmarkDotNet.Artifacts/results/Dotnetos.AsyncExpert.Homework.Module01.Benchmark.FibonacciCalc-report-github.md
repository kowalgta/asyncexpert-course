``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.264 (2004/?/20H1)
Intel Core i7-7920HQ CPU 3.10GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


```
|                   Method |  n |              Mean |           Error |          StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|------------------------- |--- |------------------:|----------------:|----------------:|------:|-------:|------:|------:|----------:|----------:|
|                **Recursive** | **15** |      **2,465.293 ns** |      **16.8215 ns** |      **14.0467 ns** | **1.000** |      **-** |     **-** |     **-** |         **-** |      **76 B** |
| RecursiveWithMemoization | 15 |          9.631 ns |       0.2157 ns |       0.3024 ns | 0.004 |      - |     - |     - |         - |     896 B |
|      IterativeDictionary | 15 |        554.569 ns |       7.5053 ns |       7.0204 ns | 0.225 | 0.2346 |     - |     - |     984 B |    1025 B |
|                Iterative | 15 |         13.646 ns |       0.1719 ns |       0.1608 ns | 0.006 |      - |     - |     - |         - |      68 B |
|                          |    |                   |                 |                 |       |        |       |       |           |           |
|                **Recursive** | **35** | **37,069,503.810 ns** | **365,147.0711 ns** | **341,558.7968 ns** | **1.000** |      **-** |     **-** |     **-** |         **-** |      **76 B** |
| RecursiveWithMemoization | 35 |         10.533 ns |       0.0678 ns |       0.0601 ns | 0.000 |      - |     - |     - |         - |     896 B |
|      IterativeDictionary | 35 |      1,262.155 ns |      17.8337 ns |      14.8920 ns | 0.000 | 0.4940 |     - |     - |    2072 B |    1025 B |
|                Iterative | 35 |         35.562 ns |       0.1460 ns |       0.1294 ns | 0.000 |      - |     - |     - |         - |      68 B |
