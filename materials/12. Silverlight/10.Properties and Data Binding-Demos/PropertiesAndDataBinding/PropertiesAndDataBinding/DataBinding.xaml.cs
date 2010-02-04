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

namespace PropertiesAndDataBinding
{
    public partial class DataBinding : UserControl
    {
        Person person;
        public DataBinding()
        {
            InitializeComponent();

            person = new Person
            {
                FirstName = "Kolio",
                LastName = "Piandeto",
                Company = "Microsoft"
            };
            LayoutRoot.DataContext = person;
        }
    }


   public class Person
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Company
        {
            get;
            set;
        }
    }

}
