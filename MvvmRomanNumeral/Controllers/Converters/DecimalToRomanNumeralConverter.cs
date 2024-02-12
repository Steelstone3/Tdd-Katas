using System;
using System.Collections.Generic;

namespace RomanNumeralKata.Converters
{
    public class DecimalToRomanNumeralConverter : IDecimalToRomanNumeralConverter
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
            if (!CheckValidRange(numeral)) { return ""; }

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

        public bool CheckValidRange(uint numeral)
        {
            bool isLessThanMinimumRange = numeral < 1;
            bool isGreaterThanMaximumRange = numeral > 3999;

            return !(isLessThanMinimumRange || isGreaterThanMaximumRange);
        }
    }
}