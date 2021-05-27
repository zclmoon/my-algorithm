using System;
using Xunit;
using HammingDistance;

namespace HammingDistanceTests
{
    public class HammingDistanceTests
    {
        [Fact]
        public void WhenPass_1_4_GetExpected_2()
        {
            int a = 1;
            int b = 4;
            int expected = 2;

            Solution solution = new Solution();

            var result = solution.HammingDistance(a, b);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenPass_256_1_GetExpected_1()
        {
            int a = 256;
            int b = 1;
            int expected = 2;

            Solution solution = new Solution();

            var result = solution.HammingDistance(a, b);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenPass_5_5_GetExpected_0()
        {
            int a = 5;
            int b = 5;
            int expected = 0;

            Solution solution = new Solution();

            var result = solution.HammingDistance(a, b);

            Assert.Equal(expected, result);
        }
    }
}
