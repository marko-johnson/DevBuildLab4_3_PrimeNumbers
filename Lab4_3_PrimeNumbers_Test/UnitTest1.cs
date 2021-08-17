using System;
using Xunit;
using Lab4_3_PrimeNumbers;

namespace Lab4_3_PrimeNumbers_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(10, false)]
        [InlineData(19, true)]
        [InlineData(23, true)]
        [InlineData(25, false)]
        [InlineData(26, false)]
        [InlineData(61, true)]
        [InlineData(64, false)]
        [InlineData(375, false)]
        [InlineData(378, false)]
        [InlineData(379, true)]
        [InlineData(383, true)]
        [InlineData(809, true)]
        [InlineData(996, false)]
        [InlineData(997, true)]

        public void TestIsPrime(int num, bool expected)
        {
            bool result = PrimeNumbers.IsPrime(num);
            Assert.Equal(expected, result);
        }
    }
}