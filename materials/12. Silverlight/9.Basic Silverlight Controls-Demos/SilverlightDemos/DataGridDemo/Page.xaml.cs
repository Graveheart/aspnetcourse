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

namespace DataGridDemo
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();

            List<Data> source = new List<Data>();
            int itemsCount = 100;

            for (int i = 0; i < itemsCount; i++)
            {
                source.Add(new Data()
                {
                    FirstName = "First",
                    LastName = "Last",
                    Age = i,
                    Available = (i % 2 == 0)
                });
            }

            dg.ItemsSource = source;
        }
    }
}
