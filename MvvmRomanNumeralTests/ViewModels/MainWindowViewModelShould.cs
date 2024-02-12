using System.Collections.Generic;
using Moq;
using MvvmRomanNumeral.ViewModels;
using MvvmRomanNumeral.ViewModels.Models;
using Xunit;

namespace BubblesDivePlannerTests.ViewModels
{
    public class MainWindowViewModelShould
    {
        private readonly MainWindowViewModel mainWindowViewModel = new();

        [Fact]
        public void AllowModelToBeSet()
        {
            //Assert
            Assert.NotNull(mainWindowViewModel.RomanNumeral);
        }

        [Fact]
        public void RaisePropertyChanged()
        {
            //Arrange
            Mock<IRomanNumeralModel> romanNumeralModel = new();
            var viewModelEvents = new List<string>();
            mainWindowViewModel.PropertyChanged += (sender, e) => viewModelEvents.Add(e.PropertyName);

            //Act
            mainWindowViewModel.RomanNumeral = romanNumeralModel.Object;

            //Assert
            Assert.Contains(nameof(mainWindowViewModel.RomanNumeral), viewModelEvents);
        }
    }
}