using System;
using Xunit;
using BitwiseAnd;

namespace BitwiseAndTests
{
    public class UnitTest1
    {
        [Fact]
        public void When_Pass_5_7_Expect_4()
        {
            int a = 5;
            int b = 7;
            int expected = 4;

            Solution solution = new Solution();
            var result = solution.RangeBitwiseAnd(a, b);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Pass_0_0_Expect_0()
        {
            int a = 0;
            int b = 0;
            int expected = 0;

            Solution solution = new Solution();
            var result = solution.RangeBitwiseAnd(a, b);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Pass_1_2147483647_Expect_0()
        {
            int a = 1;
            int b = 2147483647;
            int expected = 0;

            Solution solution = new Solution();
            var result = solution.RangeBitwiseAnd(a, b);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Pass_1_1_Expect_0()
        {
            int a = 1;
            int b = 1;
            int expected = 1;

            Solution solution = new Solution();
            var result = solution.RangeBitwiseAnd(a, b);

            Assert.Equal(expected, result);
        }
    }
}
