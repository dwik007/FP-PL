﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DWI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pepsi : ContentPage
    {
        public pepsi()
        {
            InitializeComponent();
        }
        async void gotocart(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new cart());
        }
    }
}