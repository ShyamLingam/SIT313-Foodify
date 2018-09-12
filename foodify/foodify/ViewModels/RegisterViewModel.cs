using System;
using System.Windows.Input;
using FitnessGuru.Services;
using Xamarin.Forms;

namespace FitnessGuru.ViewModels
{
    public class RegisterViewModel
    {

        ApiServices _apiServices = new ApiServices();

        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Message { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var isSuccess = await _apiServices.RegisterAsync(Email, Password, ConfirmPassword);

                    if (isSuccess)
                        Message = "Registered Sucessfully";
                    else

                        Message = "Retray later";

                });
            }




        }

    }
}
