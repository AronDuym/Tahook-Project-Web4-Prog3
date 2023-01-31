using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.Domain.Model;
using Tahook.Tests.Data;

namespace Tahook.Tests.Models
{
    public class QuizReportTest
    {
        private readonly DummyDbContext _db;

        public QuizReportTest(DummyDbContext db)
        {
            _db = db;
        }

        [Fact]
        public void QuizReport_Has_Score()
        {
            var quizReport = new QuizReport { Score = 10 };
            Assert.Equal(10, quizReport.Score);
        }

        [Fact]
        public void QuizReport_Has_Question()
        {
            var question = new Question();
            var quizReport = new QuizReport { Question = question };
            Assert.Equal(question, quizReport.Question);
        }

        [Fact]
        public void QuizReport_Has_Answer()
        {
            var answer = new Answer();
            var quizReport = new QuizReport { Answer = answer };
            Assert.Equal(answer, quizReport.Answer);
        }

        [Fact]
        public void QuizReport_Has_User()
        {
            var user = new User();
            var quizReport = new QuizReport { User = user };
            Assert.Equal(user, quizReport.User);
        }

        [Fact]
        public void QuizReport_Has_RegistrationTime()
        {
            var registrationTime = new DateTime(2023, 01, 01, 12, 0, 0);
            var quizReport = new QuizReport { RegistrationTime = registrationTime };
            Assert.Equal(registrationTime, quizReport.RegistrationTime);
        }
    }
}
