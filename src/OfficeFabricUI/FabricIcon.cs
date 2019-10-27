using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OfficeFabricUI
{
    public class FabricIcon : TextBlock
    {
        //private static readonly FontFamily _fabricFontFamily = 
        //    new FontFamily(new Uri("pack://application:,,,/OfficeFabricUI;component/Fonts/"), "./#Fabric MDL2 Assets");

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(FabricIconEnum), typeof(FabricIcon), new PropertyMetadata(FabricIconEnum.None, OnIconPropertyChanged));
        
        public FabricIconEnum Icon
        {
            get { return (FabricIconEnum)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        private static void OnIconPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //foreach (FontFamily fontFamily in Fonts.GetFontFamilies(new Uri("pack://application:,,,/OfficeFabricUI;component/Fonts/"), "./"))
            //{
            //    // Perform action.
            //    fontFamily.ToString();
            //}

            d.SetValue(TextOptions.TextRenderingModeProperty, TextRenderingMode.ClearType);
            //d.SetValue(FontFamilyProperty, _fabricFontFamily);
            d.SetValue(FontFamilyProperty, new FontFamily("Segoe MDL2 Assets"));
            d.SetValue(TextAlignmentProperty, TextAlignment.Center);
            d.SetValue(TextProperty, char.ConvertFromUtf32((int)e.NewValue));
        }
    }
}
