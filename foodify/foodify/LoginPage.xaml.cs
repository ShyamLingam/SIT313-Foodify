using System;
using System.Collections.Generic;
using foodify.Model;
using Xamarin.Forms;

namespace foodify
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }
        private async void BtnReset(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ResetPage());
        }
        private async void BtnReg(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
        private async void BtnSkipp(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        void Init()
        {

            Lbl_Login.TextColor = Constants.GreenTextColor;
            ActivitySpinner.IsVisible = false;
            Login_Icon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => Btn_Login.Focus();
            Btn_Login.BackgroundColor = Color.Orange;
            Btn_Reset.BackgroundColor = Color.Green;
            Btn_Reg.BackgroundColor = Color.Green;
        }



        void LoginClickedAsync(object sender, EventArgs eventArgs)
        {

            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "ok");
            }
            else
            {
                DisplayAlert("Login", "Username or Password is Incorrect", "ok");
            }
        }
    }
}
