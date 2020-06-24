``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.264 (2004/?/20H1)
Intel Core i7-7920HQ CPU 3.10GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


```
|            Method |  n |       Mean |    Error |   StdDev | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |--- |-----------:|---------:|---------:|----------:|-------:|------:|------:|----------:|
| **RecursiveMemoized** | **15** |   **582.7 ns** |  **5.57 ns** |  **7.98 ns** |    **1011 B** | **0.2346** |     **-** |     **-** |     **984 B** |
| **RecursiveMemoized** | **35** | **1,353.5 ns** | **11.78 ns** | **11.02 ns** |    **1011 B** | **0.4940** |     **-** |     **-** |    **2072 B** |
