using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.Converters
{
    public class ConverterGrados : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Value enlazado en binding
            //TargetType => tipo de objeto enlazado
            //parameter => parametros asociados
            if (value!=null)
            {
                if (value.ToString() != "")
                {
                    double c = Double.Parse(value.ToString());

                    double f = (c * 9 / 5) + (32);

                    return f;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
