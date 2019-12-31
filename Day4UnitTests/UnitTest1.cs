using System;
using Xunit;
using Day4;

namespace Day4UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int input = 111111;
            bool output = PasswordValidator.ValidatePassword(input);
            Assert.Equal(true, output);
        }
        [Fact]
        public void Test2()
        {
            int input = 223450;
            bool output = PasswordValidator.ValidatePassword(input);
            Assert.Equal(false, output);
        }
        [Fact]
        public void Test3()
        {
            int input = 123789;
            bool output = PasswordValidator.ValidatePassword(input);
            Assert.Equal(false, output);
        }
        [Fact]
        public void Test4()
        {
            int input = 112233;
            bool output = PasswordValidator.ValidatePasswordV2(input);
            Assert.Equal(true, output);
        }
        [Fact]
        public void Test5()
        {
            int input = 123444;
            bool output = PasswordValidator.ValidatePasswordV2(input);
            Assert.Equal(false, output);
        }
        [Fact]
        public void Test6()
        {
            int input = 111122;
            bool output = PasswordValidator.ValidatePasswordV2(input);
            Assert.Equal(true, output);
        }
    }
}
