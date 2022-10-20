``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
Intel Core i5-1035G1 CPU 1.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2


```
|       Method |         Mean |        Error |       StdDev |       Median |    Gen0 | Allocated |
|------------- |-------------:|-------------:|-------------:|-------------:|--------:|----------:|
| SingleLinked | 99,543.34 μs | 1,979.461 μs | 4,855.652 μs | 97,907.82 μs |       - | 625.23 KB |
|   NormalList |     39.29 μs |     0.621 μs |     0.518 μs |     39.29 μs | 41.6260 | 128.32 KB |
