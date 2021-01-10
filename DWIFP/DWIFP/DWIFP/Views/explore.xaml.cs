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
    public partial class explore : ContentPage
    {
        public explore()
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
        async void gotoendog(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new endog());
        }
        async void gototelur(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new telur());
        }
        async void gotoayam(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ayam());
        }
        async void gotosusu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new susu());
        }
        async void gotopepsi(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pepsi());
        }
        async void gotominyak(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new minyak());
        }
    }
}