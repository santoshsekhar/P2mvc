using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_WithTwoPositiveIntegers()
        {
            var expected = 8;
            var a = 3;
            var b = 5;
            var actual = Addition(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_WithTwoNegativeIntegers()
        {
            var expected = -9;
            var a = -4;
            var b = -5;
            var actual = Addition(a, b);
            Assert.Equal(expected, actual);
        }

       


        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(-7, -5, -12)]
        [InlineData(-5, 2, -3)]
        public void Add_WorksWithManyInputs(int n1, int n2, int value)
        {
            Assert.Equal( Addition(n1, n2), value);
        }



        int Addition(int x, int y)
        {
            return x + y;
        }

       
    }
}
