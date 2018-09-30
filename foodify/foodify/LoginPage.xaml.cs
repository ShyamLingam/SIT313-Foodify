using System;
using System.Collections.Generic;
using foodify.Model;
using SQLite;
using Xamarin.Forms;

namespace foodify
{
    public partial class LoginPage : ContentPage
    {

        public string EmailEntered;
        public string passwordEntered;
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

            Entry_Email.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => Btn_Login.Focus();
            Btn_Login.BackgroundColor = Color.Orange;
            Btn_Reset.BackgroundColor = Color.Green;
            Btn_Reg.BackgroundColor = Color.Green;
        }

       

        protected override void OnAppearing()
        {
            base.OnAppearing();


            // using instead of close();
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                var posts = conn.Table<Post>().ToList();


                var table = conn.Table<Post>();
                foreach (var s in table)
                {

                    passwordEntered = s.Password;
                    EmailEntered = s.Email;
                }
                // profilelistView.ItemsSource = posts;
            }
        }

       
        void LoginClickedAsync(object sender, EventArgs eventArgs)
        {

            bool isLoginEmailEmpty = string.IsNullOrEmpty(Entry_Email.Text);
            bool isLoginPasswordEmpty = string.IsNullOrEmpty(Entry_Password.Text);


            if (isLoginEmailEmpty || isLoginPasswordEmpty)
            {
                DisplayAlert("Login", "Username or Password is Incorrect", "ok");
            }
            if (Entry_Email.Text == EmailEntered && Entry_Password.Text == passwordEntered )
            {
                DisplayAlert("Login", "Login Success", "ok");
                Navigation.PushAsync(new MainPage());
            }


        }
    }
}
