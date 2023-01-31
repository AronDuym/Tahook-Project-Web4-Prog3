using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.Domain.Model;
using Tahook.Tests.Data;

namespace Tahook.Tests.Models
{
    public class AnswerTest
    {
        private readonly DummyDbContext _db;

        public AnswerTest(DummyDbContext db)
        {
            _db = db;
        }

        [Fact]
        public void TestAnswerDescription()
        {
            // Arrange
            var answer = new Answer();

            // Act
            answer.Description = "Answer description";

            // Assert
            Assert.Equal("Answer description", answer.Description);
        }

        [Fact]
        public void TestAnswerIsCorrect()
        {
            // Arrange
            var answer = new Answer();

            // Act
            answer.IsCorrect = true;

            // Assert
            Assert.True(answer.IsCorrect);
        }

        [Fact]
        public void TestAnswerQuestionId()
        {
            // Arrange
            var answer = new Answer();

            // Act
            answer.QuestionId = 1;

            // Assert
            Assert.Equal(1, answer.QuestionId);
        }

        [Fact]
        public void TestAnswerQuestion()
        {
            // Arrange
            var answer = new Answer();

            // Act
            answer.Question = new Question();

            // Assert
            Assert.Equal(new Question(), answer.Question);
        }

        [Fact]
        public void TestAnswerImage()
        {
            // Arrange
            var answer = new Answer();

            // Act
            answer.Image = "image.jpg";

            // Assert
            Assert.Equal("image.jpg", answer.Image);
        }
    }
}
