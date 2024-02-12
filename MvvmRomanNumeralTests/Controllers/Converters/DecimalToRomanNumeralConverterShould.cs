using System;
using RomanNumeralKata.Converters;
using Xunit;

namespace RomanNumeralKataTests.Converters
{
    public class DecimalToRomanNumeralConverterShould
    {
        private readonly IDecimalToRomanNumeralConverter decimalToRomanNumeralConverter = new DecimalToRomanNumeralConverter();

        [Theory]
        [InlineData(0)]
        [InlineData(4000)]
        public void CheckValidRange(uint outOfRange)
        {
            //Act
            bool isInRange = decimalToRomanNumeralConverter.CheckValidRange(outOfRange);

            //Assert
            Assert.False(isInRange);
        }

        [Theory]
        [InlineData(0, "")]
        [InlineData(4000, "")]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(40, "XL")]
        [InlineData(50, "L")]
        [InlineData(90, "XC")]
        [InlineData(100, "C")]
        [InlineData(400, "CD")]
        [InlineData(500, "D")]
        [InlineData(900, "CM")]
        [InlineData(1000, "M")]
        [InlineData(1994, "MCMXCIV")]
        [InlineData(3999, "MMMCMXCIX")]
        public void ConvertsDecimalToRomanNumeral(uint numeral, string expectedRomanNumeral)
        {
            // Act
            string actualRomanNumeral = decimalToRomanNumeralConverter.ConvertToRomanNumeral(numeral);

            // Assert
            Assert.Equal(expectedRomanNumeral, actualRomanNumeral);
        }
    }
}