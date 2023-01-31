using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.Domain.Model;
using Tahook.Tests.Data;

namespace Tahook.Tests.Models
{
    public class QuizTest
    {
        private readonly DummyDbContext _db;

        public QuizTest(DummyDbContext db)
        {
            _db = db;
        }

        [Fact]
        public void Quiz_Has_Name()
        {
            var quiz = new Quiz { Name = "Xunit Quiz" };
            Assert.Equal("Xunit Quiz", quiz.Name);
        }

        [Fact]
        public void Quiz_Has_PinCode()
        {
            var quiz = new Quiz { PinCode = "1234" };
            Assert.Equal("1234", quiz.PinCode);
        }

        [Fact]
        public void Quiz_Has_Start_DateTime()
        {
            var start = new DateTime(2023, 01, 01, 12, 0, 0);
            var quiz = new Quiz { Start = start };
            Assert.Equal(start, quiz.Start);
        }

        [Fact]
        public void Quiz_Has_Stop_DateTime()
        {
            var stop = new DateTime(2023, 01, 01, 13, 0, 0);
            var quiz = new Quiz { Stop = stop };
            Assert.Equal(stop, quiz.Stop);
        }

        [Fact]
        public void Quiz_Has_GameTopic()
        {
            var gameTopic = new GameTopic();
            var quiz = new Quiz { GameTopic = gameTopic };
            Assert.Equal(gameTopic, quiz.GameTopic);
        }

        [Fact]
        public void Quiz_Has_UserId()
        {
            var quiz = new Quiz { UserId = 1 };
            Assert.Equal(1, quiz.UserId);
        }

        [Fact]
        public void Quiz_Has_Users()
        {
            var users = new List<User>();
            var quiz = new Quiz { Users = users };
            Assert.Equal(users, quiz.Users);
        }

        [Fact]
        public void Quiz_Has_Questions()
        {
            var questions = new List<Question>();
            var quiz = new Quiz { Questions = questions };
            Assert.Equal(questions, quiz.Questions);
        }
    }
}
