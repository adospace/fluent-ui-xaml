using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace FluentUI.Converters
{
    public class CompactModeConverter : IValueConverter
    {
        public object CompactModeTrue { get; set; }

        public object CompactModeFalse { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool compactMode)
                return compactMode ? CompactModeTrue : CompactModeFalse;

            return CompactModeFalse;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
