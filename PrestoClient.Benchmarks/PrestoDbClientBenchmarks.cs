using System;
using System.Threading.Tasks;
using BAMCIS.PrestoClient;
using BAMCIS.PrestoClient.Interfaces;
using BAMCIS.PrestoClient.Model.Statement;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace PrestoClient.Benchmarks
{
    [MemoryDiagnoser]
    public class PrestoDbClientBenchmarks
    {
        private IPrestoClient client;

        [GlobalSetup]
        public void Setup()
        {
            var options = new PrestoClientSessionConfig
            {
                Host = "localhost",
                User = "benchmark",
                Catalog = "tpch",
                CheckInterval = 0
            };

            client = new PrestodbClient(options);
        }

        [Benchmark]
        public async Task SimpleQuery()
        {
            var query = new ExecuteQueryV1Request("SELECT * FROM sf1.customer limit 100000");
            await client.ExecuteQueryV1(query);
        }
    }
}
