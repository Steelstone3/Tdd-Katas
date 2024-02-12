using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralKata.Converters
{
    public class RomanNumeralToDecimalConverter : IRomanNumeralToDecimalConverter
    {
        private readonly Dictionary<char, uint> RomanNumeralToNumeral = new()
        {
            {'M', 1000},
            {'D', 500},
            {'C', 100},
            {'L', 50},
            {'X', 10},
            {'V', 5},
            {'I', 1},
        };

        public uint ConvertToNumeral(string romanNumeral)
        {
            if (!CheckValidRange(romanNumeral)) { return 0; }

            uint numeral = 0;
            uint previousNumeral = 0;

            for (int i = romanNumeral.Length - 1; i >= 0; i--)
            {
                uint currentNumeral = RomanNumeralToNumeral[romanNumeral[i]];

                if (currentNumeral < previousNumeral)
                {
                    numeral -= currentNumeral;
                }
                else
                {
                    numeral += currentNumeral;
                }

                previousNumeral = currentNumeral;
            }

            return numeral;
        }

        public bool CheckValidRange(string romanNumeral)
        {
            bool isOnlyRomanNumerals = false;

            if (romanNumeral != null)
            {
                isOnlyRomanNumerals = romanNumeral.ToCharArray().All(RomanNumeralToNumeral.ContainsKey);
            }

            return !(string.IsNullOrWhiteSpace(romanNumeral) || !isOnlyRomanNumerals);
        }
    }
}