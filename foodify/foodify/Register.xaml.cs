using System;
using System.Collections.Generic;
using foodify.Model;
using SQLite;
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
            BackgroundColor = Color.White;
            Login_Icon.HeightRequest = Constants.LoginIconHeight;
            lblReg.TextColor = Constants.GreenTextColor;
        }

        void BtnReg_Clicked(object sender, System.EventArgs e)
        {

            bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(pswEntry.Text);
            bool isConfirmPasswordEmpty = string.IsNullOrEmpty(cnfPswEntry.Text);
            bool isFirstNameEmpty = string.IsNullOrEmpty(fstNameEntry.Text);
            bool isLastNameEmpty = string.IsNullOrEmpty(lstNameEntry.Text);
            string password = pswEntry.Text;
            string confirmPassword = cnfPswEntry.Text;

            if (isEmailEmpty || isPasswordEmpty || isConfirmPasswordEmpty || isFirstNameEmpty || isLastNameEmpty)
            {
                DisplayAlert("Empty or incorrect data", "Please enter valid data ", "ok");
            }
            if (password != confirmPassword)
            {
                DisplayAlert("Password", "Please check the passwords", "ok");
            }
            else {

                Post post = new Post()
                {
                    Email = emailEntry.Text,

                    Password = pswEntry.Text,

                    FirstName = fstNameEntry.Text,

                    LastName = lstNameEntry.Text

                };

                /// one connection at a time so we need to close it .
                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    conn.CreateTable<Post>();
                    // insert an object
                    int rows = conn.Insert(post);
                    //conn.Close();

                    if (rows > 0)
                        DisplayAlert("Success", " Experience Successfully inserted", "ok");
                    else
                        DisplayAlert("Failed", " Experience Failed to insert", "ok");
                }

                Navigation.PushAsync(new MainPage());
            }

           
        }
    }
}
