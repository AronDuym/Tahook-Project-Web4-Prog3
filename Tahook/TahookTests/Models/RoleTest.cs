using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.Domain.Model;
using Tahook.Tests.Data;

namespace Tahook.Tests.Models
{
    public class RoleTest
    {
        private readonly DummyDbContext _db;

        public RoleTest(DummyDbContext db)
        {
            _db = db;
        }

        [Fact]
        public void Role_Has_Description()
        {
            var role = new Role { Description = "Admin" };
            Assert.Equal("Admin", role.Description);
        }

        [Fact]
        public void Role_Has_UserId()
        {
            var role = new Role { UserId = 1 };
            Assert.Equal(1, role.UserId);
        }

        [Fact]
        public void Role_Has_Users()
        {
            var users = new List<User>();
            var role = new Role { Users = users };
            Assert.Equal(users, role.Users);
        }
    }
}
