using System.Reflection;
using BenchmarkDotNet.Running;

namespace Dotnetos.AsyncExpert.Homework.Module01.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some interesting articles
            // https://stackoverflow.com/questions/42617249/time-complexity-of-memoization-fibonacci
            // https://medium.com/launch-school/recursive-fibonnaci-method-explained-d82215c5498e#:~:text=The%20recursive%20method%20(algorithm)%20%27,)%20%2B%20fibonacci(number%2D1
            // https://www.c-sharpcorner.com/UploadFile/19b1bd/calculate-fibonacci-series-in-various-ways-using-C-Sharp/
            // https://www.davidhayden.me/blog/recursive-fibonacci-and-memoization-in-csharp
#if DEBUG
            var fibonacciCalc = new FibonacciCalc();
            var res = fibonacciCalc.RecursiveWithMemoization(4);
#endif
            
// BenchmarkSwitcher
// Or you can create a set of benchmarks and choose one from command line:
// static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
// Also you can use the config command style to specify some config from command line (more @docs.console-args):
// dotnet run -c Release -- --job short --runtimes clr core --filter *BenchmarkClass1*
// dotnet run -c Release --filter *FibonacciCalc*
#if RELEASE      
            BenchmarkSwitcher.FromAssembly(Assembly.GetExecutingAssembly()).Run(args);
#endif
        }
    }
}
