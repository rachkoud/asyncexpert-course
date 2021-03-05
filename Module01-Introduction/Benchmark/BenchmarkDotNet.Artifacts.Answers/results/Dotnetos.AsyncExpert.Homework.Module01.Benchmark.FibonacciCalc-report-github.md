``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.103
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                   Method |  n |             Mean |          Error |         StdDev | Ratio | Code Size |
|------------------------- |--- |-----------------:|---------------:|---------------:|------:|----------:|
|                **Recursive** | **15** |      **2,145.21 ns** |      **34.520 ns** |      **32.290 ns** | **1.000** |      **76 B** |
| RecursiveWithMemoization | 15 |         49.97 ns |       0.918 ns |       0.982 ns | 0.023 |     294 B |
|                Iterative | 15 |         11.28 ns |       0.229 ns |       0.215 ns | 0.005 |      62 B |
|                          |    |                  |                |                |       |           |
|                **Recursive** | **35** | **33,222,017.78 ns** | **645,191.820 ns** | **603,512.828 ns** | **1.000** |      **76 B** |
| RecursiveWithMemoization | 35 |        135.11 ns |       2.364 ns |       2.095 ns | 0.000 |     294 B |
|                Iterative | 35 |         23.99 ns |       0.355 ns |       0.297 ns | 0.000 |      62 B |
