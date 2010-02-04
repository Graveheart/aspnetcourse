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

namespace ButtonDemo
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Foreground = new SolidColorBrush(Colors.Blue);
            text1.Text = "Click event handled on Hover.";
            text3.Text = "";
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Foreground = new SolidColorBrush(Colors.Green);
            text2.Text = "Click event handled on Press.";
            text3.Text = "";
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Foreground = new SolidColorBrush(Colors.Green);
            btn2.Foreground = new SolidColorBrush(Colors.Blue);
            text1.Text = "";
            text2.Text = "";
            text3.Text = "Click event handled on Release.";
        }
    }
}
