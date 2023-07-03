using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace W5CustomTextBox
{
    public class OnlyNumberAndAB
    {


        public static string GetCheckValue(DependencyObject obj)
        {
            return (string)obj.GetValue(CheckValueProperty);
        }

        public static void SetCheckValue(DependencyObject obj, char value)
        {
            obj.SetValue(CheckValueProperty, value);
        }

        // Using a DependencyProperty as the backing store for CheckValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckValueProperty =
            DependencyProperty.RegisterAttached("CheckValue", typeof(char), typeof(OnlyNumberAndAB), new PropertyMetadata((a,b) =>
            {
                var CurrentValue = a.GetValue(CheckValueProperty);

                TextBox t = (TextBox)a;
                string text = (string)a.GetValue(CheckValueProperty);
            }));


    }
}
