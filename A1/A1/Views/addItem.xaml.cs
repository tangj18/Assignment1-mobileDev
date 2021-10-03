using A1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace A1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addItem : ContentPage
    {

        ObservableCollection<stock> sp_stock;
        public addItem(ObservableCollection<stock> stock)
        {
            
            InitializeComponent();

            sp_stock = stock;

        }

        private async void saveItem(System.Object sender, System.EventArgs e)
        {
            
            sp_stock.Add(new stock {name = newName.Text, number = Convert.ToInt32(newQuant.Text), price = Convert.ToDouble(newPrice.Text)});
            await Navigation.PopAsync();
            await DisplayAlert("Done!", "New Product Added Successfully.", "OK");


        }

        private async void cancelItem(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}