using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.Domain.Model
{
    public class GameTopic
    {
        public List<Quiz> Quizzes { get; set; }

        public string Description { get; set; }
    }
}
