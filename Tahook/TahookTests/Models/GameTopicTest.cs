using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.Domain.Model;

namespace Tahook.Tests.Models
{
    public class GameTopicTest
    {
        [Fact]
        public void TestGameTopicConstructor()
        {
            // Arrange
            var description = "Game topic description";
            var quizzes = new List<Quiz>
            {
                new Quiz(),
                new Quiz(),
                new Quiz()
            };

            // Act
            var gameTopic = new GameTopic(description, quizzes);

            // Assert
            Assert.Equal(description, gameTopic.Description);
            Assert.Equal(quizzes, gameTopic.Quizzes);
        }

        [Fact]
        public void TestGameTopicProperties()
        {
            // Arrange
            var gameTopic = new GameTopic();

            // Act
            gameTopic.Description = "Game topic description";
            gameTopic.Quizzes = new List<Quiz>
            {
                new Quiz(),
                new Quiz(),
                new Quiz()
            };

            // Assert
            Assert.Equal("Game topic description", gameTopic.Description);
            Assert.Equal(3, gameTopic.Quizzes.Count);
            Assert.Equal(new Quiz(), gameTopic.Quizzes[0]);
            Assert.Equal(new Quiz(), gameTopic.Quizzes[1]);
            Assert.Equal(new Quiz(), gameTopic.Quizzes[2]);
        }
    }
}
