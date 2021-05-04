using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BENET.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }

        public User()
        {
            UserEmail = "";
            Password = "";
        }

        public User(string Email, string Pass)
        {
            this.UserEmail = Email;
            this.Password = Pass;
        }
    }
}
