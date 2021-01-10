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
    public partial class checkout : ContentPage
    {
        public checkout()
        {
            InitializeComponent();
        }
        async void gotoordersukses(object sender, EventArgs e)
        {

            var result=await DisplayAlert("pesan", "apakah anda yakin melanjutkan?", "ya", "tidak");
            if(result)await Navigation.PushAsync(new ordersukses());
        }
    }
}