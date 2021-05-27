using Xunit;
using HammingDistance;

namespace HammingDistanceTests
{
    public class CountOneNumberInBitsTests
    {
        [Fact]
        public void WhenPass_52_ExpectGet_3()
        {
            int x = 52;
            int expected = 3;

            CountOneNumberInBits counInBits = new CountOneNumberInBits();
            var result = counInBits.CountOneInBitsSet(x);

            Assert.Equal(expected, result);
        }
    }
}