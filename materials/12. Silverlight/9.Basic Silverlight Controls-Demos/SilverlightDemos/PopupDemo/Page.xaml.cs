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
using System.Windows.Controls.Primitives;

namespace PopupDemo
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }

        Popup p = new Popup();
        private void showPopup_Click(object sender, RoutedEventArgs e)
        {
            // Create some content to show in the popup. Typically you would 
            // create a user control.
            Border border = new Border();
            border.BorderBrush = new SolidColorBrush(Colors.Black);
            border.BorderThickness = new Thickness(5.0);

            StackPanel panelPopup = new StackPanel();
            panelPopup.Background = new SolidColorBrush(Colors.LightGray);

            Button buttonShowPopup = new Button();
            buttonShowPopup.Content = "Close";
            buttonShowPopup.Margin = new Thickness(5.0);
            buttonShowPopup.Click += new RoutedEventHandler(buttonShowPopup_Click);
            TextBlock textblockPopup = new TextBlock();
            textblockPopup.Text = "The popup control";
            textblockPopup.Margin = new Thickness(5.0);
            panelPopup.Children.Add(textblockPopup);
            panelPopup.Children.Add(buttonShowPopup);
            border.Child = panelPopup;

            // Set the Child property of Popup to the border 
            // which contains a stackpanel, textblock and button.
            p.Child = border;

            // Set where the popup will show up on the screen.
            p.VerticalOffset = 25;
            p.HorizontalOffset = 25;

            // Open the popup.
            p.IsOpen = true;
        }

        void buttonShowPopup_Click(object sender, RoutedEventArgs e)
        {
            // Close the popup.
            p.IsOpen = false;
        }
    }
}
