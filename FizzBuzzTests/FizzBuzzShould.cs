using FizzBuzzKata;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzShould
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        public void ConvertNumbersToFizzBuzz(uint number, string expected)
        {
            // Given
            IFizzBuzz fizzBuzz = new FizzBuzz();

            // When
            string actual = fizzBuzz.Convert(number);

            // Then
            Assert.Equal(expected, actual);
        }
    }
}