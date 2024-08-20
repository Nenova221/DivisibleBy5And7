using DivisibilityCheck;
using Xunit;

namespace DivisibleBy5And7Test
{
    public class DivisibleBy5And7Test
    {
        [Theory]
        [InlineData(35, true)]
        [InlineData(17, false)]
        [InlineData(10, false)]
        public void InDivisibleBy5And7_WithCheckIfisDivisible_ReturnsCorrectResult(int input, bool expected)
        {
            bool result = DivisibilityCheck.IsDivisibleBy5And7(input);
            Assert.Equal(expected, result);
        }
    }
}