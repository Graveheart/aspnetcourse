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
using System.Windows.Browser;

namespace EventBubblingDemo
{
    public partial class EventBubbling : UserControl
    {
        public EventBubbling()
        {
            InitializeComponent();
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HtmlPage.Window.Alert("Button MouseLeftButtonDown");
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HtmlPage.Window.Alert("Grid MouseLeftButtonDown");
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HtmlPage.Window.Alert("Canvas MouseLeftButtonDown");
        }

        private void myEllipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HtmlPage.Window.Alert("Ellipse MouseLeftButtonDown");
        }
    }
}
