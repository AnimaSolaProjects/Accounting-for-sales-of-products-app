using System;

namespace M___C_part.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool LevelOfAccess { get; set; }

        public User(string login, string password, DateTime createdDate, bool levelOfAccess)
        { 
            Login = login;
            Password = password;
            CreatedDate = createdDate;
            LevelOfAccess = levelOfAccess;
        }
    }
}
