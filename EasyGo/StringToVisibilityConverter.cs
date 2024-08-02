using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
using System.Windows;
using System.Windows.Data;



namespace EasyGo
{
    public class StringToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string str && !string.IsNullOrEmpty(str))
            {
                return Visibility.Collapsed; // Hide the placeholder if there is text
            }
            return Visibility.Visible; // Show the placeholder if there is no text
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}


