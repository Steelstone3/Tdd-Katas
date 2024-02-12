namespace RomanNumeralKata.Converters
{
    public interface IDecimalToRomanNumeralConverter
    {
        bool CheckValidRange(uint numeral);
        string ConvertToRomanNumeral(uint numeral);
    }
}
