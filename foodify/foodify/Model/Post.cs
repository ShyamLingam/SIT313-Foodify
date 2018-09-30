using System;
using SQLite;

namespace foodify.Model
{
        public class Post
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }


            //sqlite attributes 
            [MaxLength(250)]
            public string Email { get; set; }

            [MaxLength(250)]
            public string Password { get; set; }

            [MaxLength(250)]
            public string FirstName { get; set; }

            [MaxLength(250)]
            public string LastName { get; set; }

            //[MaxLength(3)]
            //public string Age { get; set; }

        }
    }
