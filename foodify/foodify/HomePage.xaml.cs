using System;
using System.Collections.Generic;
using foodify.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace foodify
{
    public partial class HomePage : ContentPage
    {
        public const string V = "Completed";
        public event EventHandler<SelectedItemChangedEventArgs> SelectedOrToggled;

        //Food List view
        public HomePage()
        {
            InitializeComponent();
            GetData();
            Init();
            //BindingContext = new HomePage();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            lbnlRoutine.TextColor = Constants.GreenTextColor;

        }



        public async void GetData()
        {

            //HttpClient client = new HttpClient();
            var client = new System.Net.Http.HttpClient();
            var response = await client.GetAsync("http://demo7712681.mockable.io/foodify");
            string JsonData = await response.Content.ReadAsStringAsync();
            foodList ObjfoodList = new foodList();


            if (JsonData != "null")
            {
                ObjfoodList = JsonConvert.DeserializeObject<foodList>(JsonData);

            }
            WorkoutListView.ItemsSource = ObjfoodList.cookingList;
        }



        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var view = sender as BindableObject;
            SelectedOrToggled?.Invoke(this, new
            SelectedItemChangedEventArgs(view.BindingContext));
        }

        //XAML usage




    }
}