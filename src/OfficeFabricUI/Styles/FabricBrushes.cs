using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace OfficeFabricUI.Styles
{
    public static class FabricBrushes
    {
        static FabricBrushes()
        {
            MyColor.Freeze();
        }

        public static SolidColorBrush MyColor { get; } = new SolidColorBrush(Colors.Red);
    }
}
