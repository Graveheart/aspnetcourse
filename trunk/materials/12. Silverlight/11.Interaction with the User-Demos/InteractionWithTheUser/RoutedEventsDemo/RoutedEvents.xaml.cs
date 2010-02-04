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

namespace RoutedEventsDemo
{
    public partial class RoutedEvents : UserControl
    {
        public RoutedEvents()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(Page_Loaded);
        }

        void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Hello.Click += new RoutedEventHandler(Hello_Click);
            BusyButton.Click +=
                new RoutedEventHandler(BusyButton_MouseLeftButtonDown);
            Loud.MouseLeftButtonDown +=
                new MouseButtonEventHandler(Loud_MouseLeftButtonDown);
            ExtraLoud.MouseLeftButtonDown +=
                new MouseButtonEventHandler(ExtraLoud_MouseLeftButtonDown);
            LoudCheckBox.MouseLeftButtonDown +=
                new MouseButtonEventHandler(LoudCheckBox_MouseLeftButtonDown);
            CheckBoxBorder.MouseLeftButtonDown +=
                new MouseButtonEventHandler(CheckBoxBorder_MouseLeftButtonDown);
        }

        void CheckBoxBorder_MouseLeftButtonDown(
            object sender, MouseButtonEventArgs e)
        {
            Message.Items.Add("CheckBoxBorder clicked");
        }

        void LoudCheckBox_MouseLeftButtonDown(
            object sender, MouseButtonEventArgs e)
        {
            Message.Items.Add("LoudCheckBox clicked");
        }

        void ExtraLoud_MouseLeftButtonDown(
            object sender, MouseButtonEventArgs e)
        {
            Message.Items.Add("Extra Loud Clicked");
        }

        void Loud_MouseLeftButtonDown(
            object sender, MouseButtonEventArgs e)
        {
            Message.Items.Add("Loud clicked");
        }

        void BusyButton_MouseLeftButtonDown(
            object sender, RoutedEventArgs e)
        {
            PlayText.Text =
                PlayText.Text == "Play" ? "Pause" : "Play";
        }

        void Hello_Click(object sender, RoutedEventArgs e)
        {
            Hello.Content =
                Hello.Content.ToString() == "Hello" ? "Goodbye" : "Hello";
        }
    }
}

