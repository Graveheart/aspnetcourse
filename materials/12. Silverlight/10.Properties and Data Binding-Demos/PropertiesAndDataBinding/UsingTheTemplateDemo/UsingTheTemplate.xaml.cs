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

namespace UsingTheTemplateDemo
{
    public partial class UsingTheTemplate : UserControl
    {
        public UsingTheTemplate()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(Page_Loaded);
        }

        void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Performers.Click += new RoutedEventHandler(Button_Click);
            Album disc = new Album();
            disc.Group = "Chalga Rock";
            disc.AlbumName = "Falling rocks";
            disc.Genre = "Hard";
            disc.Performers = new List<string>() 
            { 
                "Kondio", 
                "Milko Kalaidjiev", 
                "Petra", 
                "Konstantin", 
                "Pepa", 
                "Bai Mangal"
            };
            StackOfBalls.DataContext = disc;

        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement fe = sender as FrameworkElement;
            Msg.Text = fe.Name + " was clicked!";
        }
    }
}
