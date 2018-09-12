using System;
using System.Net.Http;
using System.Threading.Tasks;
using foodify.Model;
using Newtonsoft.Json;

namespace foodify.Services
{
    public class ApiServices
    {
        public async Task<bool> RegisterAsync(string email, string password, string confirmpassword)
        {
            var client = new HttpClient();

            var model = new RegisterBindingModel
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmpassword

            };

            var json = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(json);
            var response = await client.PostAsync("https://my-json-server.typicode.com/typicode/demo/posts", content);
            return response.IsSuccessStatusCode;
        }
    }
}
