using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace OfficeFabricUI
{
    public static class PasswordHelper
    {
        public static bool GetCheckPasswordIsEmpty(DependencyObject obj)
        {
            return (bool)obj.GetValue(CheckPasswordIsEmptyProperty);
        }

        public static void SetCheckPasswordIsEmpty(DependencyObject obj, bool value)
        {
            obj.SetValue(CheckPasswordIsEmptyProperty, value);
        }

        // Using a DependencyProperty as the backing store for CheckPasswordIsEmpty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckPasswordIsEmptyProperty =
            DependencyProperty.RegisterAttached("CheckPasswordIsEmpty", typeof(bool), typeof(PasswordHelper), 
                new PropertyMetadata(false, new PropertyChangedCallback(OnCheckPasswordIsEmptyPropertyChangeCallback)));

        private static void OnCheckPasswordIsEmptyPropertyChangeCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is PasswordBox passwordBox))
            {
                throw new InvalidOperationException();
            }

            if ((bool)e.OldValue == true)
            {
                passwordBox.PasswordChanged -= PassWordBox_PasswordChanged;
            }

            if (!(bool)e.NewValue)
                return;
            
            SetHasPasswordEmpty(passwordBox, string.IsNullOrEmpty(passwordBox.Password));

            passwordBox.PasswordChanged += PassWordBox_PasswordChanged;
        }

        private static void PassWordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = (PasswordBox)sender;
            SetHasPasswordEmpty(passwordBox, string.IsNullOrEmpty(passwordBox.Password));
        }

        public static bool GetHasPasswordEmpty(DependencyObject obj)
        {
            return (bool)obj.GetValue(HasPasswordEmptyProperty);
        }

        public static void SetHasPasswordEmpty(DependencyObject obj, bool value)
        {
            obj.SetValue(HasPasswordEmptyProperty, value);
        }

        // Using a DependencyProperty as the backing store for HasPasswordEmpty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HasPasswordEmptyProperty =
            DependencyProperty.RegisterAttached("HasPasswordEmpty", typeof(bool), typeof(PasswordHelper), new PropertyMetadata(true));


    }
}
