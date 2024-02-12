using System;
using System.Reactive;
using MvvmRomanNumeral.ViewModels.Models;
using ReactiveUI;
using RomanNumeralKata.Converters;

namespace MvvmRomanNumeral.ViewModels
{
    public class RomanNumeralViewModel : ReactiveObject, IRomanNumeralModel
    {
        private readonly IRomanNumeralToDecimalConverter romanNumeralToDecimalConverter;
        private readonly IDecimalToRomanNumeralConverter decimalToRomanNumeralConverter;

        public RomanNumeralViewModel(IRomanNumeralToDecimalConverter romanNumeralToDecimalConverter, IDecimalToRomanNumeralConverter decimalToRomanNumeralConverter)
        {
            this.romanNumeralToDecimalConverter = romanNumeralToDecimalConverter;
            this.decimalToRomanNumeralConverter = decimalToRomanNumeralConverter;
            ConvertToNumeralCommand = ReactiveCommand.Create(ConvertToNumeral, CanConvertToNumeral);
            // , CanConvertToRomanNumeral
            ConvertToRomanNumeralCommand = ReactiveCommand.Create(ConvertToRomanNumeral, CanConvertToRomanNumeral);
        }

        private uint numeral;
        public uint Numeral
        {
            get => numeral;
            set => this.RaiseAndSetIfChanged(ref numeral, value);
        }

        private string romanNumeral = string.Empty;
        public string RomanNumeral
        {
            get => romanNumeral;
            set => this.RaiseAndSetIfChanged(ref romanNumeral, value);
        }

        public ReactiveCommand<Unit, Unit> ConvertToNumeralCommand { get; }

        public ReactiveCommand<Unit, Unit> ConvertToRomanNumeralCommand { get; }

        public IObservable<bool> CanConvertToNumeral => this.WhenAnyValue
        (
            vm => vm.RomanNumeral,
            romanNumeralToDecimalConverter.CheckValidRange
        );

        public IObservable<bool> CanConvertToRomanNumeral => this.WhenAnyValue
        (
            vm => vm.Numeral,
            decimalToRomanNumeralConverter.CheckValidRange
        );

        private void ConvertToNumeral()
        {
            Numeral = romanNumeralToDecimalConverter.ConvertToNumeral(RomanNumeral);
        }

        private void ConvertToRomanNumeral()
        {
            RomanNumeral = decimalToRomanNumeralConverter.ConvertToRomanNumeral(numeral);
        }
    }
}