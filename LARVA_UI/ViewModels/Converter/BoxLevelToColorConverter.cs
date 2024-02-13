using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace LARVA_UI.ViewModels
{
    public class BoxLevelToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BoxInfo input = value as BoxInfo;
            if (input != null)
            {
                    switch (input.BoxLevel)
                    {
                        case 1: return Brushes.AliceBlue; // 성충
                        case 2: return Brushes.LightGreen; // 알
                        case 3: return Brushes.OrangeRed;
                        case 4: return Brushes.LightYellow;
                        case 5: return Brushes.LightCoral;
                        case 6: return Brushes.DarkGray;
                        case 7: return Brushes.SandyBrown;
                        default: return Brushes.Black; // 기본 색상
                    }
            }
            return Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
