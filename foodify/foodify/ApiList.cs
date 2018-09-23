using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace foodify
{
    public class ApiList
        {
        public string id { get; set; }

        public string Recipe { get; set; }

        public string Ingredients { get; set; }

        public string Instructions { get; set; }

    }
    public class foodList
    {
        public List<ApiList> workouts { get; set; }
    }
}

