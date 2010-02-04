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
using System.IO.IsolatedStorage;
using System.IO;

namespace ManagedCodeInSilverlight
{
    public partial class UsingIsolatedStorage : UserControl
    {
        public UsingIsolatedStorage()
        {
            InitializeComponent();
        }

        private void buttonWrite_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IsolatedStorageFile store =
                  IsolatedStorageFile.GetUserStoreForApplication();
                using (IsolatedStorageFileStream fs = new IsolatedStorageFileStream(
                  "date.txt", FileMode.Create, store))
                {
                    StreamWriter w = new StreamWriter(fs);
                    w.Write(DateTime.Now);
                    w.Close();
                }

                txtData.Text = "Data written to date.txt";
            }
            catch (Exception err)
            {
                txtData.Text = err.Message;
            }
        }

        private void buttonRead_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IsolatedStorageFile store =
                  IsolatedStorageFile.GetUserStoreForApplication();
                using (IsolatedStorageFileStream fs = new IsolatedStorageFileStream(
                  "date.txt", FileMode.Open, store))
                {
                    StreamReader r = new StreamReader(fs);
                    txtData.Text = r.ReadLine();
                    r.Close();
                }
            }
            catch (Exception err)
            {
                // An exception will occur if you attempt to open a file that doesn't exist.
                txtData.Text = err.Message;
            }
        }
    }
}
