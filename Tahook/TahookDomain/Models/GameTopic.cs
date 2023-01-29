using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.Domain.Model
{
    public class GameTopic
    {
        public string Description { get; set; }

        public List<Quiz> Quizzes { get; set; }

        public GameTopic(string description, List<Quiz> quizzes)
        {
            Description = description;
            Quizzes = quizzes;
        }
    }
}
