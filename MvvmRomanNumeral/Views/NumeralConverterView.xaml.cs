using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MvvmRomanNumeral.Views
{
    public class NumeralConverterView : UserControl
    {
        public NumeralConverterView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
