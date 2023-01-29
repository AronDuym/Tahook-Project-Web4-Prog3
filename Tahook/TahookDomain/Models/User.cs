using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.Domain.Model
{
    public class User
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }

        public Quiz Quiz { get; set; }

        public User(string userName, string email, string password, Role role, Quiz quiz)
        {
            UserName = userName;
            Email = email;
            Password = password;
            Role = role;
            Quiz = quiz;
        }
    }
}
