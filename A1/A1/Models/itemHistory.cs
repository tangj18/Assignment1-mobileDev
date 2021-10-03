using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace A1.Models
{
    public class itemHistory : INotifyPropertyChanged
    {
        private string _name;
        private int _quantity;
        private string _time;
        private double _total;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == _name)
                {
                    return;
                }

                _name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(name)));
                }
            }
        }
        public int quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value == _quantity)
                {
                    return;
                }

                _quantity = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(quantity)));
                }
            }
        }
        public string time
        {
            get
            {
                return _time;
            }
            set
            {
                if (value == _time)
                {
                    return;
                }

                _time = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(time)));
                }
            }
        }
        public double total
        {
            get
            {
                return _total;
            }
            set
            {
                if (value == _total)
                {
                    return;
                }

                _total = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(total)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public itemHistory()
        {

        }

        public itemHistory(string n, int tempNum, string t, double tot)
        {
            this.name = n;
            quantity = tempNum;
            this.time = t;
            total = tot;

        }
    }
}
