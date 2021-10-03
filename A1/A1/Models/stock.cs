using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace A1.Models
{
    public class stock : INotifyPropertyChanged
    {
        private string _name;
        private int _number;
        private double _price;

        public event PropertyChangedEventHandler PropertyChanged;

        public string name {
            get { 
                return _name;
            }
            set
            {
                if(value == _name)
                {
                    return;
                }

                _name = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(name)));
                }
            }
        }
        public int number {
            get
            {
                return _number;
            }
            set
            {
                if(value == _number)
                {
                    return;
                }

                _number = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(number)));
                
            }
        }
        public double price {
            get
            {
                return _price;
            }
            set
            {
                if (value == _price)
                {
                    return;
                }

                _price = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(price)));

            }
        }
        public stock()
        {
           
        }
        public stock(string name, int num, double p)
        {
            this.name = name;
            number = num;
            price = p;
            
        }

        
    }
}