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

namespace MouseEvents
{
    public partial class MouseEvents : UserControl
    {
        public MouseEvents()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseEnter(object sender, MouseEventArgs e)
        {
            Ellipse el = sender as Ellipse;
            SolidColorBrush brush = new SolidColorBrush(Colors.Yellow);
            el.Fill =brush;
            eventInfo.Text = "MouseEnter: " + sender + " named " + el.Name;
        }

        private void Ellipse_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse el = sender as Ellipse;
            SolidColorBrush brush = new SolidColorBrush(Colors.Green);
            el.Fill = brush;
            eventInfo.Text = "MouseLeave: " + sender + " named " + el.Name;
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse el = sender as Ellipse;
            SolidColorBrush brush = new SolidColorBrush(Colors.Blue);
            el.Fill = brush;
            eventInfo.Text = "MouseLeftButtonDown: " + sender + " named " + el.Name;
        }

        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            Ellipse el = sender as Ellipse;
            SolidColorBrush brush = new SolidColorBrush(Colors.Orange);
            el.Fill = brush;
            eventInfo.Text = "MouseMove: " + sender + " named " + el.Name;
        }

        private void Ellipse_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Ellipse el = sender as Ellipse;
            SolidColorBrush brush = new SolidColorBrush(Colors.Purple);
            el.Fill = brush;
            eventInfo.Text = "MouseLeftButtonUp: " + sender + " named " + el.Name;
        }
    }
}
