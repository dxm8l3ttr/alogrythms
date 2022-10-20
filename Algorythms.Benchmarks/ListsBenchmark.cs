using Algorythms.Core;
using BenchmarkDotNet.Attributes;

namespace Algorythms.Benchmarks;

[MemoryDiagnoser]
public class ListsBenchmark
{
    [Benchmark]
    public void SingleLinked()
    {
        var list = new SingleLinkedList<int>();
        foreach (var i in ..10000)
        {
            list.Add(i);
        }

        var reverse = list.Reversed();
    }
    
    [Benchmark]
    public void NormalList()
    {
        var list = new List<int>();
        foreach (var i in ..10000)
        {
            list.Add(i);
        }

        list.Reverse();
    }
}