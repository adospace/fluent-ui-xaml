using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace FluentUI
{
    public class FabricChromeButton : Button
    {
        public FabricChromeButton()
        { 
        
        }

        public FabricChromeButtonMode Mode { get; set; }

        protected override void OnClick()
        {
            var parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                switch (Mode)
                {
                    case FabricChromeButtonMode.Close:
                        SystemCommands.CloseWindow(parentWindow);
                        break;
                    case FabricChromeButtonMode.Minimize:
                        SystemCommands.MinimizeWindow(parentWindow);
                        break;
                    case FabricChromeButtonMode.Maximize:
                        SystemCommands.MaximizeWindow(parentWindow);
                        break;
                    case FabricChromeButtonMode.Restore:
                        SystemCommands.RestoreWindow(parentWindow);
                        break;
                }
            }
            base.OnClick();
        }
    }
}
