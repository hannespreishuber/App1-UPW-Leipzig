using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace App1
{
    class PersonConv:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
          if(value.ToString().Length>5)
            {
                return new SolidColorBrush(Colors.LightPink);
            }
          else
            {
                return new SolidColorBrush(Colors.LightGreen);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
