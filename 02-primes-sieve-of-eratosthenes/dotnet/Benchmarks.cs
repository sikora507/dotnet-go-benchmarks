using BenchmarkDotNet.Attributes;

[ShortRunJob]
public class Benchmarks
{
    [Benchmark]
    [Arguments(1000)]
    [Arguments(10000)]
    [Arguments(100000)]
    [Arguments(1000000)]
    public long[] PrimesSieveBenchmark(long range) => PrimesSieve.FindPrimeNumbersSieve(range);
}