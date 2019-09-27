using BenchmarkDotNet.Running;
using System;

namespace DDBenchmarkCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Benchmark>();
            Console.ReadKey();
        }
    }
}
