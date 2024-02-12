using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MvvmRomanNumeral.Views
{
    public class RomanNumeralConverterView : UserControl
    {
        public RomanNumeralConverterView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
