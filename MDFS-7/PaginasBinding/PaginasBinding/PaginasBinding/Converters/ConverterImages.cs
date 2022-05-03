using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.Converters
{
    public class ConverterImages : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int numero = (int)value;
            if (numero > 0) return "https://www.pinclipart.com/picdir/big/156-1566327_flecha-hacia-arriba-gif-clipart.png";     
            else return "https://cdn.pixabay.com/photo/2016/03/31/14/47/download-1292814_960_720.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
