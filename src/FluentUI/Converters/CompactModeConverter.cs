using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;
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

    public class CompactModeThicknessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                throw new InvalidOperationException();

            var tokens = parameter.ToString().Split('|');
            if (tokens.Length != 2)
                throw new InvalidOperationException();

            var trueThickness = (Thickness)(new ThicknessConverter()).ConvertFromInvariantString(tokens[0]);
            var falseThickness = (Thickness)(new ThicknessConverter()).ConvertFromInvariantString(tokens[1]);

            if (value is bool compactMode)
                return compactMode ? trueThickness : falseThickness;

            return falseThickness;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class CompactModeDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                throw new InvalidOperationException();

            var tokens = parameter.ToString().Split('|');
            if (tokens.Length != 2)
                throw new InvalidOperationException();

            var trueDouble = double.Parse(tokens[0], CultureInfo.InvariantCulture);
            var falseDouble = double.Parse(tokens[1], CultureInfo.InvariantCulture);

            if (value is bool compactMode)
                return compactMode ? trueDouble : falseDouble;

            return falseDouble;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
