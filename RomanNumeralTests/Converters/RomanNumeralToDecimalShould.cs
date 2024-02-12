using System;
using RomanNumeralKata.Converters;
using Xunit;

namespace RomanNumeralKataTests.Converters
{
    public class RomanNumeralToDecimalShould
    {
        private readonly IRomanNumeralToDecimal decimalToRomanNumeralConverter = new RomanNumeralToDecimal();

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("  ")]
        [InlineData("AB")]
        [InlineData("ABC")]
        [InlineData("095453ABC")]
        [InlineData("095453ABC£$&()")]
        public void ThrowsAnExceptionIfOutOfRange(string outOfRange)
        {
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => decimalToRomanNumeralConverter.ConvertToDecimal(outOfRange));
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("XL", 40)]
        [InlineData("L", 50)]
        [InlineData("XC", 90)]
        [InlineData("C", 100)]
        [InlineData("CD", 400)]
        [InlineData("D", 500)]
        [InlineData("CM", 900)]
        [InlineData("M", 1000)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("MMMCMXCIX", 3999)]
        public void ConvertRomanNumeralToDecimal(string romanNumeral, uint expectedDecimal)
        {
            // Act
            uint actualDecimal = decimalToRomanNumeralConverter.ConvertToDecimal(romanNumeral);

            // Assert
            Assert.Equal(expectedDecimal, actualDecimal);
        }
    }
}