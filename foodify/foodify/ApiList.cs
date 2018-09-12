using System;

using Xamarin.Forms;

namespace foodify
{
    public class ApiList : ContentPage
    {
        public ApiList()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

