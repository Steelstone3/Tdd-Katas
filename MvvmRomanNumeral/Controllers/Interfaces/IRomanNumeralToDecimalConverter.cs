namespace RomanNumeralKata.Converters
{
    public interface IRomanNumeralToDecimalConverter
    {
        bool CheckValidRange(string romanNumeral);
        uint ConvertToNumeral(string romanNumeral);
    }
}