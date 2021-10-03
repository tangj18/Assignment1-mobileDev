using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class historyDetail : ContentPage
    {
        
        public historyDetail(string name, int quantity, string time, double total)
        {
            InitializeComponent();
            title.Title = name;
            itemName.Text = name;
            itemQuantity.Text = quantity.ToString();
            itemTime.Text = time;
            itemTotal.Text = "Total amount: $" + total.ToString();

        }
    }
}