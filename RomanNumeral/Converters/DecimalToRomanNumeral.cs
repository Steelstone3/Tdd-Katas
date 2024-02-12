using System;
using System.Collections.Generic;

namespace RomanNumeralKata.Converters
{
    public class DecimalToRomanNumeral : IDecimalToRomanNumeral
    {
        private readonly Dictionary<uint, string> NumeralToRomanNumeral = new()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

        public string ConvertToRomanNumeral(uint numeral)
        {
            CheckValidRange(numeral);

            string romanNumeral = string.Empty;

            foreach (var item in NumeralToRomanNumeral)
            {
                while (numeral >= item.Key)
                {
                    romanNumeral += item.Value;
                    numeral -= item.Key;
                }
            }

            return romanNumeral;
        }
        private static void CheckValidRange(uint numeral)
        {
            bool isLessThanMinimumRange = numeral < 1;
            bool isGreaterThanMaximumRange = numeral > 3999;

            if (isLessThanMinimumRange || isGreaterThanMaximumRange)
            {
                const string OUT_OF_RANGE_EXCEPTION_MESSAGE = "Decimal number must be between 1 and 3999.";
                throw new ArgumentOutOfRangeException(nameof(numeral), OUT_OF_RANGE_EXCEPTION_MESSAGE);
            }
        }
    }
}