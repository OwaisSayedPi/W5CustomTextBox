using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace W5CustomTextBox
{
    public class NumberAndABOnly:TextBox
    {
        
        public string MyProperty { get; set; }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.Key is Key.A || e.Key is Key.B || e.Key is Key.D0 || e.Key is Key.D1|| e.Key is Key.D2|| e.Key is Key.D3|| e.Key is Key.D4|| e.Key is Key.D5|| e.Key is Key.D6|| e.Key is Key.D7|| e.Key is Key.D8|| e.Key is Key.D9 || e.Key is Key.NumPad0 || e.Key is Key.NumPad1 || e.Key is Key.NumPad2 || e.Key is Key.NumPad3 || e.Key is Key.NumPad4 || e.Key is Key.NumPad5 || e.Key is Key.NumPad6 || e.Key is Key.NumPad7 || e.Key is Key.NumPad8 || e.Key is Key.NumPad9)
            {                
            }
            else
            {
                for (int i = 0; i < Text.Length; i++)
                {
                    if (Text[i] == 'A' || Text[i] == 'a' || Text[i] == 'B' || Text[i] == 'b')
                    {
                        
                    }
                    else
                    {
                        Text = Text.Remove(i);
                    }
                }
            }
        }
    }
}
