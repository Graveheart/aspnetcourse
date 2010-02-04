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

namespace AnimationDemo
{
    public partial class Animation : UserControl
    {
        public Animation()
        {
            InitializeComponent();
            TextBlockMyMessage.MouseLeftButtonDown += new MouseButtonEventHandler(MyMessage_MouseLeftButtonDown);
        }

        void MyMessage_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            TextBlockMyMessage.Text = "I was pushed !";
        }
    }
}
