using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace PersonSender.ViewModels.Converters
{
    public class BackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           if(value != null)
            {
                if (value.ToString() == "Male")
                {
                    return new SolidColorBrush(Color.FromArgb(255, 27, 161, 226));

                }
                else
                {
                    return new SolidColorBrush(Color.FromArgb(255, 216, 0, 115));
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
