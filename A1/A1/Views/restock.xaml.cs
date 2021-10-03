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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class restock : ContentPage
    {
        public restock()
        {
            InitializeComponent();

            stockList.ItemsSource = cashreg.stock;
        }

        bool set = false;
        void onSelected(System.Object sender,
           Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

            if (this.stockList.SelectedItem != null)
            {
                set = true;
               
            }
        }

        void restockButton(System.Object sender, System.EventArgs e)
        {
            if (!set || restockQuantity.Text == null)
            {
                DisplayAlert("Error", "You have to select an item and provide a new quantity", "OK");
            }
            else
            {
                var isNum = int.TryParse(restockQuantity.Text, out int n);
                if (isNum)
                {
                    int newQuant = Convert.ToInt32(restockQuantity.Text) + (stockList.SelectedItem as stock).number;
                    (stockList.SelectedItem as stock).number = newQuant;
                    restockQuantity.Text = null;
                   

                    stockList.SelectedItem = null;
                    set = false;
                }
                else
                {
                    DisplayAlert("Error!","Please enter in a valid quantity", "Ok");
                }
            }
        }
        private async void cancelButton(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}