``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.103
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                   Method |  n |              Mean |           Error |          StdDev | Ratio | Code Size |
|------------------------- |--- |------------------:|----------------:|----------------:|------:|----------:|
|                **Recursive** | **15** |      **2,252.895 ns** |      **44.5732 ns** |      **47.6929 ns** | **1.000** |      **76 B** |
| RecursiveWithMemoization | 15 |        575.685 ns |       9.3505 ns |       8.7464 ns | 0.255 |     993 B |
|                Iterative | 15 |          9.240 ns |       0.1726 ns |       0.1615 ns | 0.004 |      62 B |
|                          |    |                   |                 |                 |       |           |
|                **Recursive** | **35** | **33,125,119.583 ns** | **518,346.2799 ns** | **484,861.4318 ns** | **1.000** |      **76 B** |
| RecursiveWithMemoization | 35 |      1,385.411 ns |      26.2476 ns |      40.0829 ns | 0.000 |     993 B |
|                Iterative | 35 |         23.659 ns |       0.3321 ns |       0.3107 ns | 0.000 |      62 B |
