using System;
using System.Threading.Tasks;

namespace CoverletAwaitBranchCoverage
{
    public class Program
    {
        public static async Task Main()
        {
            await Task.CompletedTask;
            Console.WriteLine("Hello World!");
        }
    }
}
