﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.Domain.Model
{
    public class User
    {

        public string Naam { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }

        public User(string naam, string email, string password, Role role)
        {
            Naam = naam;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
