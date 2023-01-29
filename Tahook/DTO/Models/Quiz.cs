using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.DTO.Model
{
    public class Quiz
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PinCode { get; set; }

        public DateTime Start { get; set; }

        public DateTime Stop { get; set; }

        public GameTopic GameTopic { get; set; }

        public int UserId { get; set; }
        public List<User> Users { get; set; }

        public List<Question> Questions { get; set; }

        //public Quiz(int id, string name, string pinCode, DateTime start, DateTime stop, GameTopic gameTopic, User user)
        //{
        //    Id = id;
        //    Name = name;
        //    PinCode = pinCode;
        //    Start = start;
        //    Stop = stop;
        //    GameTopic = gameTopic;
        //}

        //public Quiz(int id, string name, string pinCode, DateTime start, DateTime stop)
        //{
        //    Id = id;
        //    Name = name;
        //    PinCode = pinCode;
        //    Start = start;
        //    Stop = stop;
        //}
    }
}
