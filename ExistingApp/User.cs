using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistingApp
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string us, string pass)
        {
            Username = us;
            Password = pass;
        }
    }
}
