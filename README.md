# Roman Numeral Kata

This branch shows the solution and instructions for the "Roman Numeral" kata

## Functional Requirements

A time travelling Emperor Nero has tasked you (in Latin no less) to create a roman to decimal and decimal to roman converter on "one of those thinking machines".

See [roman numerals](https://en.wikipedia.org/wiki/Roman_numerals) for an explanation on how they work.

The decimal to roman numeral converter will do the following:

- Convert a decimal integer number from 1 to 3999 into roman numeral

The roman numeral converter will do the following:

- Convert a roman numeral string into a decimal integer number accurate in the range of 1 to 3999
- Throw an exception if the roman numeral **does not contain only** I, V, X, L, C, D or M.

**Optionally** the converter will have:

- (Optional) a console front end to enter values to be converted

## Constraints

The converters will work in the range of 1 to 3999

The converters will take the following interfaces

For the roman numeral to decimal converter:

```cs
public interface IRomanNumeralToDecimal 
{
    uint ConvertToDecimal(string romanNumeral);
}
```

For the decimal to roman numeral converter:

```cs
public interface IDecimalToRomanNumeral
{
    string ConvertToRomanNumeral(uint numeral);
}
```

## Example

Roman Numeral to Decimal Converter

- I → 1
- VI → 6
- XVI → 106
- MCMXCIV → 1994
- MMMCMXCIX → 3999

Decimal to Roman Numeral Converter

- 1 → I
- 6 → VI
- 106 → XVI
- 1994 → MCMXCIV
- 3999 → MMMCMXCIX
