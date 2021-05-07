using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace PrestoClient.Benchmarks
{
    public class Program
    {
        public static void Main()
        {
            var summary = BenchmarkRunner.Run<PrestoDbClientBenchmarks>();
        }
    }
}