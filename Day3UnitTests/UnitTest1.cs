using System;
using Xunit;
using Day3;

namespace Day3UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string[] wire1_directions = {"R8","U5","L5","D3"};
            string[] wire2_directions = {"U7","R6","D4","L4"};
            int output = WireIntersectCalculator.ShortestIntersectionDistance(wire1_directions, wire2_directions);
            Assert.Equal(6, output);
        }
        
        [Fact]
        public void Test2()
        {
            string[] wire1_directions = {"R75","D30","R83","U83","L12","D49","R71","U7","L72"};
            string[] wire2_directions = {"U62","R66","U55","R34","D71","R55","D58","R83"};
            int output = WireIntersectCalculator.ShortestIntersectionDistance(wire1_directions, wire2_directions);
            Assert.Equal(159, output);
        }
        
        [Fact]
        public void Test3()
        {
            string[] wire1_directions = {"R98","U47","R26","D63","R33","U87","L62","D20","R33","U53","R51"};
            string[] wire2_directions = {"U98","R91","D20","R16","D67","R40","U7","R15","U6","R7"};
            int output = WireIntersectCalculator.ShortestIntersectionDistance(wire1_directions, wire2_directions);
            Assert.Equal(135, output);
        }

        [Fact]
        public void Test4()
        {
            string[] wire1_directions = {"R8","U5","L5","D3"};
            string[] wire2_directions = {"U7","R6","D4","L4"};
            int output = WireIntersectCalculator.ShortestWireLengthIntersectionDistance(wire1_directions, wire2_directions);
            Assert.Equal(30, output);
        }
        [Fact]
        public void Test5()
        {
            string[] wire1_directions = {"R75","D30","R83","U83","L12","D49","R71","U7","L72"};
            string[] wire2_directions = {"U62","R66","U55","R34","D71","R55","D58","R83"};
            int output = WireIntersectCalculator.ShortestWireLengthIntersectionDistance(wire1_directions, wire2_directions);
            Assert.Equal(610, output);
        }
        [Fact]
        public void Test6()
        {
            string[] wire1_directions = {"R98","U47","R26","D63","R33","U87","L62","D20","R33","U53","R51"};
            string[] wire2_directions = {"U98","R91","D20","R16","D67","R40","U7","R15","U6","R7"};
            int output = WireIntersectCalculator.ShortestWireLengthIntersectionDistance(wire1_directions, wire2_directions);
            Assert.Equal(410, output);
        }
    }
}
