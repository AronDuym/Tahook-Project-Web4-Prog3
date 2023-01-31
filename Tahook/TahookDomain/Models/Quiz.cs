using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.Domain.Model
{
    public class Quiz
    {
        public string Name { get; set; }

        public string PinCode { get; set; }

        public DateTime Start { get; set; }

        public DateTime Stop { get; set; }

        public GameTopic GameTopic { get; set; }

        public int UserId { get; set; }
        public List<User> Users { get; set; }

        public List<Question> Questions { get; set; }

        public Quiz(string name, string pinCode, DateTime start, DateTime stop, GameTopic gameTopic, int userId, List<User> users, List<Question> questions)
        {
            Name = name;
            PinCode = pinCode;
            Start = start;
            Stop = stop;
            GameTopic = gameTopic;
            UserId = userId;
            Users = users;
            Questions = questions;
        }

        public Quiz()
        {
        }
    }
}
