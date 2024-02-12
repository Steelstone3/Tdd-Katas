using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralKata.Converters
{
    public class RomanNumeralToDecimal : IRomanNumeralToDecimal
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

        public uint ConvertToDecimal(string romanNumeral)
        {
            CheckValidRange(romanNumeral);

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

        private void CheckValidRange(string romanNumeral)
        {
            bool isOnlyRomanNumerals = false;

            if (romanNumeral != null)
            {
                isOnlyRomanNumerals = romanNumeral.ToCharArray().All(rn => RomanNumeralToNumeral.ContainsKey(rn));
            }

            if (string.IsNullOrWhiteSpace(romanNumeral) || !isOnlyRomanNumerals)
            {
                const string OUT_OF_RANGE_EXCEPTION_MESSAGE = "Roman numeral must contain I, V, X, L, C, D or M.";
                throw new ArgumentOutOfRangeException(nameof(romanNumeral), OUT_OF_RANGE_EXCEPTION_MESSAGE);
            }
        }
    }
}