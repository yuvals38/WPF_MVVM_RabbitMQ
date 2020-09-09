using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersonSender.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { 
                name = value;
                OnPropertyChanged("Name");
                OnPropertyChanged("Fullname");
            
            }
        }

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { 
                lastname = value;
                OnPropertyChanged("Lastname");
                OnPropertyChanged("Fullname");
            }
        }

        private string fullname;

        public string Fullname
        {
            get { return name + " " + lastname; }
            set { 
                fullname = value;
                OnPropertyChanged("Fullname");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Person()
        { 
           
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
