using System;
using Xunit;
using Day1;

namespace Day1UnitTests
{
    public class FuelCalculatorTests
    {
        [Fact]
        public void Test1()
        {
            int fuel = Day1.FuelCalculator.ComputeFuel(12);
            Assert.Equal(2, fuel);
        }

        [Fact]
        public void Test2()
        {
            int fuel = Day1.FuelCalculator.ComputeFuel(14);
            Assert.Equal(2, fuel);
        }

        [Fact]
        public void Test3()
        {
            int fuel = Day1.FuelCalculator.ComputeFuel(1969);
            Assert.Equal(966, fuel);
        }

        [Fact]
        public void Test4()
        {
            int fuel = Day1.FuelCalculator.ComputeFuel(100756);
            Assert.Equal(50346, fuel);
        }

        [Fact]
        public void TestNegative()
        {
            int fuel = Day1.FuelCalculator.ComputeFuel(-1);
            Assert.Equal(0, fuel);
        }
    }
}
