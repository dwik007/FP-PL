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
    public partial class Registrasi : ContentPage
    {
        public Registrasi()
        {
            InitializeComponent();
        }

        async void SignupProcedure(object sender, EventArgs e)
        {
            await DisplayAlert("Pesan", "Pendaftaran", "Berhasil");
            await Navigation.PushAsync(new Login());
        }

        async void GotoLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}