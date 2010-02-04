using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.Generic;

namespace UsingTheTemplateDemo
{
    public class Album : INotifyPropertyChanged
    {
        private string group;
        private string albumName;
        private string genre;
        private List<string> performers;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Group
        {
            get { return group; }
            set
            {
                group = value;
                NotifyPropertyChanged("Group");
            }
        }

        public string AlbumName
        {
            get { return albumName; }
            set
            {
                albumName = value;
                NotifyPropertyChanged("AlbumName");
            }
        }

        public string Genre
        {
            get { return genre; }
            set
            {
                genre = value;
                NotifyPropertyChanged("Genre");
            }
        }

        public List<string> Performers
        {
            get { return performers; }
            set
            {
                performers = value;
                NotifyPropertyChanged("Performers");
            }
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }  
        }      
    }             
}
