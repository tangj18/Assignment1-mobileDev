using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace A1.Views
{

    public partial class history : ContentPage
    {
        ObservableCollection<itemHistory> sp_item;
        public history(ObservableCollection<itemHistory> items)
        {
            InitializeComponent();
            sp_item = items;
            historyList.ItemsSource = sp_item;

        }

        private async void onSelect(System.Object sender,
           Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var itemDetail = historyList.SelectedItem as itemHistory;
            await Navigation.PushAsync(new historyDetail(itemDetail.name, itemDetail.quantity, itemDetail.time, itemDetail.total));
        }
    }
}