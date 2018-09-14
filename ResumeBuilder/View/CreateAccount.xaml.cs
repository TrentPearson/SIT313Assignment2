using System;
using System.Collections.Generic;
using ResumeBuilder.View;
using Xamarin.Forms;

namespace ResumeBuilder
{
    public partial class CreateAccount : ContentPage
    {
        public CreateAccount()
        {
            InitializeComponent();

        }
        private async void backBtn(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        private async void signup(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}
