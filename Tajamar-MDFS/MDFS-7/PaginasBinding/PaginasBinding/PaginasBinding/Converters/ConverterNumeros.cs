using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.Converters
{
    public class ConverterNumeros : IValueConverter
    {
        public Color ColorNegativo { get; set; }
        public Color ColorPositivo { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int numero = (int) value;
            Color color;
            if (numero > 0) color = ColorPositivo;
            else color = ColorNegativo;
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
