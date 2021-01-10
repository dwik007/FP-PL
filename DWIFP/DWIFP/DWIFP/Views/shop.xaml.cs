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
    public partial class shop : ContentPage
    {
        public shop()
        {
            InitializeComponent();
        }
        async void gotoshop(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new shop());
        }
        async void gotoexplore(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new explore());
        }
        async void gotocart(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new cart());
        }
        async void gotofavourite(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Favourite());
        }
    }
}