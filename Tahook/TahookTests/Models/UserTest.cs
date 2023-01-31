using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.Domain.Model;
using Tahook.Tests.Data;

namespace Tahook.Tests.Models
{
    public class UserTest
    {
        private readonly DummyDbContext _db;
        
        public UserTest(DummyDbContext db)
        {
            _db = db;
        }

        [Fact]
        public void User_Has_UserName()
        {
            var user = new User { UserName = "john" };
            Assert.Equal("john", user.UserName);
        }

        [Fact]
        public void User_Has_Email()
        {
            var user = new User { Email = "john@example.com" };
            Assert.Equal("john@example.com", user.Email);
        }

        [Fact]
        public void User_Has_Password()
        {
            var user = new User { Password = "p@ssw0rd" };
            Assert.Equal("p@ssw0rd", user.Password);
        }

        [Fact]
        public void User_Has_Role()
        {
            var role = new Role();
            var user = new User { Role = role };
            Assert.Equal(role, user.Role);
        }

        [Fact]
        public void User_Has_Quiz()
        {
            var quiz = new Quiz();
            var user = new User { Quiz = quiz };
            Assert.Equal(quiz, user.Quiz);
        }

    }
}
