using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace foodify
{
    public class ApiList
        {
        public string id { get; set; }

        public string name { get; set; }

        public string excercise { get; set; }
        }
    public class foodList
    {
        public List<ApiList> workouts { get; set; }
    }
}

