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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void GotoRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrasi());
        }

        async void SigninProcedure(object sender, EventArgs e)
        {
            await DisplayAlert("Pesan", "Berhasil Login", "Oke");
            await Navigation.PushAsync(new shop());
        }
    }
}