using System;
using Xunit;
using PowerOfTwo;

namespace PowerOfTwoTests
{
    public class UnitTest1
    {
        [Fact]
        public void When_Pass_16_Expect_True()
        {
            int a = 16;
            bool expected = true;

            Solution solution = new Solution();
            var result = solution.IsPowerOfTwo(a);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Pass_15_Expect_False()
        {
            int a = 15;
            bool expected = false;

            Solution solution = new Solution();
            var result = solution.IsPowerOfTwo(a);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Pass_0_Expect_False()
        {
            int a = 0;
            bool expected = false;

            Solution solution = new Solution();
            var result = solution.IsPowerOfTwo(a);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Pass_negtive_2147483648_Expect_False()
        {
            int a = -2147483648;
            bool expected = false;

            Solution solution = new Solution();
            var result = solution.IsPowerOfTwo(a);

            Assert.Equal(expected, result);
        }
    }
}
