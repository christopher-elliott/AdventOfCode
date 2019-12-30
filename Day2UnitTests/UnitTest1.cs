using System;
using Xunit;
using Day2;

namespace Day2UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] input = {1,9,10,3,2,3,11,0,99,30,40,50};
            string output = IntcodeProcessor.ProcessIntcode(input);
            Assert.Equal("3500,9,10,70,2,3,11,0,99,30,40,50", output);
        }
		
		[Fact]
        public void Test2()
        {
        	// 1,0,0,0,99 becomes 2,0,0,0,99 (1 + 1 = 2).
            int[] input = {1,0,0,0,99};
            string output = IntcodeProcessor.ProcessIntcode(input);
            Assert.Equal("2,0,0,0,99", output);
        }
		
		[Fact]
        public void Test3()
        {
        	// 2,3,0,3,99 becomes 2,3,0,6,99 (3 * 2 = 6).
            int[] input = {2,3,0,3,99};
            string output = IntcodeProcessor.ProcessIntcode(input);
            Assert.Equal("2,3,0,6,99", output);
        }
		
		[Fact]
        public void Test4()
        {
        	// 2,4,4,5,99,0 becomes 2,4,4,5,99,9801 (99 * 99 = 9801).
            int[] input = {2,4,4,5,99,0};
            string output = IntcodeProcessor.ProcessIntcode(input);
            Assert.Equal("2,4,4,5,99,9801", output);
        }
		
		[Fact]
        public void Test5()
        {
        	// 1,1,1,4,99,5,6,0,99 becomes 30,1,1,4,2,5,6,0,99.
            int[] input = {1,1,1,4,99,5,6,0,99};
            string output = IntcodeProcessor.ProcessIntcode(input);
            Assert.Equal("30,1,1,4,2,5,6,0,99", output);
        }
    }
}
