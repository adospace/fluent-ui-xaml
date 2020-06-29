using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FluentUI
{
    public class FabricWindow : Window
    {
        static FabricWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FabricWindow), 
                new FrameworkPropertyMetadata(typeof(FabricWindow)));
        }


    }
}
