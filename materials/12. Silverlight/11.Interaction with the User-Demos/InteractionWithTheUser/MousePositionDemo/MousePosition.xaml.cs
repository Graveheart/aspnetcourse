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

namespace MousePositionDemo
{
    public partial class MousePosition : UserControl
    {
        public MousePosition()
        {
            InitializeComponent();
        }

        private void Canvas_MouseEnter(object sender, MouseEventArgs e)
        {
            Point mousePoints = new Point();
            mousePoints.X = e.GetPosition(null).X;
            mousePoints.Y = e.GetPosition(null).Y;
            MousePositionText.Text = "X: " + mousePoints.X + "  Y: " + mousePoints.Y;
        }
    }
}
