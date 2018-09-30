using System;
using System.Collections.Generic;
using foodify.Model;
using SQLite;
using Xamarin.Forms;

namespace foodify
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
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
                    FirstNamelbl.Text = s.FirstName ;
                    LastNamelbl.Text = s.LastName;
                    Emaillbl.Text = s.Email;
                }
               // profilelistView.ItemsSource = posts;
            }
        }
    }
}