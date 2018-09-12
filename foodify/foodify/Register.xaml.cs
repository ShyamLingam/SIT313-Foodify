using System;
using System.Collections.Generic;
using foodify.Model;
using Xamarin.Forms;

namespace foodify
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();


            Init();
        }

        private async void BtnRLogin(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void BtnSkip(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Login_Icon.HeightRequest = Constants.LoginIconHeight;
            lblReg.TextColor = Constants.GreenTextColor;
        }
    }
}
