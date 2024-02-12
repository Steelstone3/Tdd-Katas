using System.Collections.Generic;
using Moq;
using MvvmRomanNumeral.ViewModels;
using RomanNumeralKata.Converters;
using Xunit;

namespace MvvmRomanNumeralTests.ViewModels
{
    public class RomanNumeralViewModelShould
    {
        private readonly Mock<IDecimalToRomanNumeralConverter> decimalToRomanNumeralConverter = new();
        private readonly Mock<IRomanNumeralToDecimalConverter> romanNumeralToDecimalConverter = new();
        private readonly RomanNumeralViewModel romanNumeralViewModel;

        public RomanNumeralViewModelShould()
        {
            romanNumeralViewModel = new(romanNumeralToDecimalConverter.Object, decimalToRomanNumeralConverter.Object);
        }

        [Fact]
        public void AllowModelToBeSet()
        {
            // Arrange
            const uint numeral = 0;

            // Assert
            Assert.NotNull(romanNumeralViewModel.RomanNumeral);
            Assert.Equal(numeral, romanNumeralViewModel.Numeral);
        }

        [Fact]
        public void RaisePropertyChanged()
        {
            //Arrange
            const uint numeral = 2;
            const string romanNumeral = "XV";
            var viewModelEvents = new List<string>();
            romanNumeralViewModel.PropertyChanged += (sender, e) => viewModelEvents.Add(e.PropertyName);

            //Act
            romanNumeralViewModel.RomanNumeral = romanNumeral;
            romanNumeralViewModel.Numeral = numeral;

            //Assert
            Assert.Contains(nameof(romanNumeralViewModel.RomanNumeral), viewModelEvents);
            Assert.Contains(nameof(romanNumeralViewModel.Numeral), viewModelEvents);
        }
    }
}