using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FluentUI
{
    public static class FabricExtra
    {
        public static string GetLabel(DependencyObject obj)
        {
            return (string)obj.GetValue(LabelProperty);
        }

        public static void SetLabel(DependencyObject obj, string value)
        {
            obj.SetValue(LabelProperty, value);
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.RegisterAttached("Label", typeof(string), typeof(FabricExtra), new PropertyMetadata(null));

        public static bool GetIsRequired(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsRequiredProperty);
        }

        public static void SetIsRequired(DependencyObject obj, bool value)
        {
            obj.SetValue(IsRequiredProperty, value);
        }

        public static readonly DependencyProperty IsRequiredProperty =
            DependencyProperty.RegisterAttached("IsRequired", typeof(bool), typeof(FabricExtra), new PropertyMetadata(false));


        public static string GetErrorMessage(DependencyObject obj)
        {
            return (string)obj.GetValue(ErrorMessageProperty);
        }

        public static void SetErrorMessage(DependencyObject obj, string value)
        {
            obj.SetValue(ErrorMessageProperty, value);
        }

        public static readonly DependencyProperty ErrorMessageProperty =
            DependencyProperty.RegisterAttached("ErrorMessage", typeof(string), typeof(FabricExtra), new PropertyMetadata(null));



        public static string GetPlaceholder(DependencyObject obj)
        {
            return (string)obj.GetValue(PlaceholderProperty);
        }

        public static void SetPlaceholder(DependencyObject obj, string value)
        {
            obj.SetValue(PlaceholderProperty, value);
        }

        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.RegisterAttached("Placeholder", typeof(string), typeof(FabricExtra), new PropertyMetadata(null));


        public static string GetCompactMode(DependencyObject obj)
        {
            return (string)obj.GetValue(LabelProperty);
        }

        public static void SetCompactMode(DependencyObject obj, bool value)
        {
            obj.SetValue(LabelProperty, value);
        }

        public static readonly DependencyProperty CompactModeProperty =
            DependencyProperty.RegisterAttached("CompactMode", typeof(bool), typeof(FabricExtra), new FrameworkPropertyMetadata(false));

    }
}
