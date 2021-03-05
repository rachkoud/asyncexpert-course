``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.103
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                   Method |  n |             Mean |          Error |         StdDev | Ratio | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |--- |-----------------:|---------------:|---------------:|------:|----------:|-------:|------:|------:|----------:|
|                **Recursive** | **15** |      **2,184.04 ns** |      **39.745 ns** |      **37.178 ns** | **1.000** |      **76 B** |      **-** |     **-** |     **-** |         **-** |
| RecursiveWithMemoization | 15 |        551.41 ns |       7.493 ns |       6.257 ns | 0.252 |     993 B | 0.1173 |     - |     - |     984 B |
|                Iterative | 15 |         11.08 ns |       0.248 ns |       0.314 ns | 0.005 |      62 B |      - |     - |     - |         - |
|                          |    |                  |                |                |       |           |        |       |       |           |
|                **Recursive** | **35** | **35,234,401.90 ns** | **442,563.298 ns** | **413,973.983 ns** | **1.000** |      **76 B** |      **-** |     **-** |     **-** |         **-** |
| RecursiveWithMemoization | 35 |      1,346.16 ns |       7.524 ns |       5.874 ns | 0.000 |     993 B | 0.2460 |     - |     - |    2072 B |
|                Iterative | 35 |         28.97 ns |       0.235 ns |       0.196 ns | 0.000 |      62 B |      - |     - |     - |         - |
