using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumeBuilder.View;
using Xamarin.Forms;

namespace ResumeBuilder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            //BackgroundImage = "backgroundImage2.jpg";
            //Opacity = 0.4;
        }
        

    private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new CreateAccount());
        }

        private async void loginBtn(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new HomePage());
        }
    }
}
