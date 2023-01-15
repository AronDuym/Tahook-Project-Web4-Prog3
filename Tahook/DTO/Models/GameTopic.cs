using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.DTO.Model
{
    public class GameTopic
    {
        public int Id { get; set; }

        public List<Quiz> Quizzes { get; set; }

        public string Description { get; set; }
    }
}
