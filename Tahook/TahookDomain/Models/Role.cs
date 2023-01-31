using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.Domain.Model
{
    public class Role
    {
        public string Description { get; set; }

        public int UserId { get; set; }

        public List<User> Users { get; set; }

        public Role(string description, int userId, List<User> users)
        {
            Description = description;
            UserId = userId;
            Users = users;
        }

        public Role()
        {

        }
    }
}
