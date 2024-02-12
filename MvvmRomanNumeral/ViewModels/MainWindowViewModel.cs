using MvvmRomanNumeral.ViewModels.Models;
using ReactiveUI;
using RomanNumeralKata.Converters;

namespace MvvmRomanNumeral.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        public MainWindowViewModel()
        {
            romanNumeralModel = new RomanNumeralViewModel
            (
                new RomanNumeralToDecimalConverter(),
                new DecimalToRomanNumeralConverter()
            );
        }

        private IRomanNumeralModel romanNumeralModel;
        public IRomanNumeralModel RomanNumeral
        {
            get => romanNumeralModel;
            set => this.RaiseAndSetIfChanged(ref romanNumeralModel, value);
        }
    }
}