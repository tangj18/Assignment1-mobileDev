using A1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A1.Views
{

    public partial class cashreg : ContentPage
    {
        public static ObservableCollection<stock> stock { get; set; }

        public static ObservableCollection<itemHistory> itemHistories { get; set; }

        public cashreg()
        {
            InitializeComponent();

            itemHistories = new ObservableCollection<itemHistory> { };

            stock = new ObservableCollection<stock>
            {
                new stock(){name = "Pants", number = 20, price = 12.99},
                new stock(){name = "Shoes", number = 50, price = 14.99},
                new stock(){name = "Hats", number = 10, price = 18.99},
                new stock(){name = "T-shirts", number = 10, price = 11.99},
                new stock(){name = "Dresses", number = 24, price = 13.99}
  
            };
            stockList.ItemsSource = stock;

                
        }
        double price = 0;
        int quantity = 0;
        bool set = false;
        void onSelected(System.Object sender,
           Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            
            if(this.stockList.SelectedItem != null)
            {
                itemText.Text = (e.SelectedItem as stock).name;
                quantity = (e.SelectedItem as stock).number;
                price = (e.SelectedItem as stock).price;
                set = true;
            }
           
            
        }

        void onNumberPressed(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;
            if (set)
            {

                if (quantityText.Text == "Quantity")
                {
                    quantityText.Text = pressed;
                    totalText.Text = (Int32.Parse(pressed) * price).ToString();
                }
                else if (quantityText.Text == "0")
                {
                    quantityText.Text = pressed;
                    totalText.Text = "0.00";
                }
                else
                {
                    quantityText.Text += pressed;

                }
                double val = Int32.Parse(quantityText.Text) * price;
                val = System.Math.Round(val, 2);
                totalText.Text = val.ToString();

            }
        }

        void clearQuantity(System.Object sender, System.EventArgs e)
        {
            quantityText.Text = "Quantity";
            totalText.Text = "Total";
        }

        void purchaseItem(System.Object sender, System.EventArgs e)
        {
            
            if (quantityText.Text == "Quantity")
            {

            }
            else if (Convert.ToInt32(quantityText.Text) > (stockList.SelectedItem as stock).number)
            {
                DisplayAlert("Error!", "Not enough stock, please select less quantity.", "ok");
            }
            else
            {
                string tempName = (stockList.SelectedItem as stock).name;
                int tempQuantity = Convert.ToInt32(quantityText.Text);
                string tempTime = DateTime.Now.ToString();
                double tempTot = Convert.ToDouble(totalText.Text);

                (stockList.SelectedItem as stock).number -= Convert.ToInt32(quantityText.Text);

                itemHistories.Add(new itemHistory() {name = tempName, quantity = tempQuantity, time = tempTime, total = tempTot });
                
                quantityText.Text = "Quantity";
                totalText.Text = "Total";
                itemText.Text = "Type";
                stockList.SelectedItem = null;
                set = false;
            }           
            
        }

        private async void managerView(System.Object sender, System.EventArgs e)
        {
            
            await Navigation.PushAsync(new managerView(stock, itemHistories));
        }


    }
}