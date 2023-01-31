using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.Domain.Model;
using Tahook.Tests.Data;

namespace Tahook.Tests.Models
{
    public class QuestionTest
    {
        private readonly DummyDbContext _db;

        public QuestionTest(DummyDbContext db)
        {
            _db = db;
        }

        [Fact]
        public void Question_Has_Description()
        {
            var question = new Question { Description = "What is Xunit?" };
            Assert.Equal("What is Xunit?", question.Description);
        }

        [Fact]
        public void Question_Has_IsActive_Flag()
        {
            var question = new Question { IsActive = true };
            Assert.True(question.IsActive);
        }

        [Fact]
        public void Question_Has_DurationTime()
        {
            var question = new Question { DurationTime = 60 };
            Assert.Equal(60, question.DurationTime);
        }

        [Fact]
        public void Question_Has_QuizId()
        {
            var question = new Question { QuizId = 1 };
            Assert.Equal(1, question.QuizId);
        }

        [Fact]
        public void Question_Has_Quiz()
        {
            var quiz = new Quiz();
            var question = new Question { Quiz = quiz };
            Assert.Equal(quiz, question.Quiz);
        }

        [Fact]
        public void Question_Has_Answers()
        {
            var answers = new List<Answer>();
            var question = new Question { Answers = answers };
            Assert.Equal(answers, question.Answers);
        }
    }
}
