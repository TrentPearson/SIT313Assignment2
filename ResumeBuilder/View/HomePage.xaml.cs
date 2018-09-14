using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ResumeBuilder.View
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private async void backBtn(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}
