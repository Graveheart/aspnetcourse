using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace KeyboardEventsDemo
{
    public partial class KeyboardEvents : UserControl
    {
        public KeyboardEvents()
        {
            InitializeComponent();
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key.ToString() == "Ctrl")
            {
                return;
            }
            int keyCode = e.PlatformKeyCode;
            if (keyCode == 32 || //space
               (keyCode >= 48 && keyCode <= 57 && e.Key.ToString() != "Shift") || //numbers
               (keyCode >= 65 && keyCode <= 90))
            { //letters
                if ((keyCode >= 65 && keyCode <= 90) && e.Key.ToString() != "Shift")
                {
                    keyCode += 32;
                }
                InputBox.Text = InputBox.Text + ((char)keyCode).ToString();
            }
            else if (e.PlatformKeyCode == 8)
            {
                string text = InputBox.Text;
                InputBox.Text = text.Substring(0, text.Length - 1);
            }
        }
    }
}
