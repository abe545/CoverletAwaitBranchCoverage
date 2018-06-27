using System;
using System.Threading.Tasks;
using Xunit;
using CoverletAwaitBranchCoverage;

namespace CoverletAwaitBranchCoverageTest
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            await Program.Main();
        }
    }
}
