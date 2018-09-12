using System;
namespace FitnessGuru.Model
{
    public class User
    {
        public int Id { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }

        public User() {}

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInformation()
        {
            if (this.Username != null && this.Password != null)
            {
                return true;
            }
                
            else
            {
                return false;
            }
                
        }
    }
}
