using System;
using Xunit;

namespace IntegrationTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() => Assert.Equal(4, Calc(2,2));
        [Fact]
        public void Test2() => Assert.Equal(-6, Calc(-2,-4));
        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData(-8, -5, -3)]
        [InlineData(-9, -11, 2)]

        public void Test3(int ans, int a, int b) => Assert.Equal(ans, Calc(a, b));



        int Calc(int a, int b)
        {
            return a + b;
        }
        
    }
    
}
