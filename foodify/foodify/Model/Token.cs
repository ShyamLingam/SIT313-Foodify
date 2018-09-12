using System;
namespace FitnessGuru.Model
{
    public class Token
    {
        public int Id { set; get; }
        public string access_token { set; get; }
        public string error_description { set; get; }
        public DateTime expire_date { set; get; }

        public Token() {}
    }
}
