using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanNumeralGenerator
    {
        public string RomanFor(int decimalNumber)
        {
            string romanNumeral = string.Empty;

            var numerals = GenerateRomanNumeralsMap();

            foreach (var numeral in numerals)
            {
                while (decimalNumber >= numeral.Value)
                {
                    romanNumeral += numeral.Key;
                    decimalNumber -= numeral.Value;
                }
            }

            return romanNumeral;
        }

        private IDictionary<string, int> GenerateRomanNumeralsMap()
        {
            IDictionary<string, int> DecimalToRomanMap = new Dictionary<string, int>();
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("M", 1000));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("CM", 900));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("D", 500));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("CD", 400));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("C", 100));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("XC", 90));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("L", 50));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("XL", 40));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("X", 10));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("IX", 9));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("V", 5));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("IV", 4));
            DecimalToRomanMap.Add(new KeyValuePair<string, int>("I", 1));

            return DecimalToRomanMap;
        }
    }
}