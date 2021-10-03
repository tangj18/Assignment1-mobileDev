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
    public partial class managerView : ContentPage
    {
        ObservableCollection<stock> sp_stock;
        ObservableCollection<itemHistory> sp_itemHistories;
        public managerView(ObservableCollection<stock> stock, ObservableCollection<itemHistory> item)
        {
            InitializeComponent();
            sp_stock = stock;
            sp_itemHistories = item;
        }

        private async void historyPage(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new history(sp_itemHistories));
        }

        private async void restockPage(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new restock());
        }

        private async void addItemPage(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new addItem(sp_stock));
        }
    }
}