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

namespace InteractionWithTheUser
{
    public partial class EventListeners : UserControl
    {
        public EventListeners()
        {
            InitializeComponent();
            myEllipse.MouseEnter += new MouseEventHandler(MouseEnterMethod);
        }

        private void MouseEnterMethod(object sender, MouseEventArgs e)
        {
            HtmlPage.Window.Alert("Ouch, says " + sender.ToString());
        }
    }
}
