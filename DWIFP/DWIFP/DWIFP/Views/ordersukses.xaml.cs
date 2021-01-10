using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DWI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ordersukses : ContentPage
    {
        public ordersukses()
        {
            InitializeComponent();
        }
        async void gotoshop(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new shop());
        }
    }
}