``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.103
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                   Method |  n |             Mean |          Error |         StdDev | Ratio | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |--- |-----------------:|---------------:|---------------:|------:|----------:|-------:|------:|------:|----------:|
|                **Recursive** | **15** |      **2,198.75 ns** |      **43.222 ns** |      **42.449 ns** | **1.000** |      **76 B** |      **-** |     **-** |     **-** |         **-** |
| RecursiveWithMemoization | 15 |         51.41 ns |       0.990 ns |       0.926 ns | 0.023 |     294 B | 0.0172 |     - |     - |     144 B |
|                Iterative | 15 |         11.00 ns |       0.174 ns |       0.154 ns | 0.005 |      62 B |      - |     - |     - |         - |
|                          |    |                  |                |                |       |           |        |       |       |           |
|                **Recursive** | **35** | **33,149,055.36 ns** | **430,987.637 ns** | **382,059.314 ns** | **1.000** |      **76 B** |      **-** |     **-** |     **-** |         **-** |
| RecursiveWithMemoization | 35 |        139.30 ns |       2.047 ns |       1.709 ns | 0.000 |     294 B | 0.0362 |     - |     - |     304 B |
|                Iterative | 35 |         29.65 ns |       0.582 ns |       0.516 ns | 0.000 |      62 B |      - |     - |     - |         - |
