using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;

namespace BindingAtRuntime
{
    public partial class BindingAtRuntime : UserControl
    {
        public BindingAtRuntime()
        {
            InitializeComponent();
        }

        private void buttonDateTimeNow_Click(object sender, RoutedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            Binding binding = new Binding("TimeOfDay");
            binding.Source = currentTime;
            binding.Mode = BindingMode.OneWay;
            myTextBox.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
