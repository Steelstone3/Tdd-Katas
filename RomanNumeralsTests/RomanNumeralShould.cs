using RomanNumerals;
using Xunit;

namespace RomanNumerals.Tests
{
    public class RomanNumeralsShould
    {
        [Theory]
        [InlineData(1,"I")]
        [InlineData(2,"II")]
        [InlineData(3,"III")]
        [InlineData(5,"V")]
        [InlineData(7,"VII")]
        [InlineData(10,"X")]
        [InlineData(18,"XVIII")]
        [InlineData(30,"XXX")]
        [InlineData(4,"IV")]
        [InlineData(9,"IX")]
        [InlineData(2687,"MMDCLXXXVII")]
        [InlineData(3499, "MMMCDXCIX")]
        public void GenerateARomanNumeralForAGivenDecimalNumber(int decimalNumber, string romanNumeral)
        {
            Assert.Equal(new RomanNumeralGenerator().RomanFor(decimalNumber), romanNumeral);
        }
    }
}
