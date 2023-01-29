namespace Tahook.DTO.Model
{
    public class QuizReport
    {
        public int Id { get; set; }

        public int Score { get; set; }

        public Question Question { get; set; }

        public Answer Answer { get; set; }

        public User User { get; set; }

        public DateTime RegistrationTime { get; set; }

        //public QuizReport(int id, int score, Question question, Answer answer, User user, DateTime registrationTime)
        //{
        //    Id = id;
        //    Score = score;
        //    Question = question;
        //    Answer = answer;
        //    User = user;
        //    RegistrationTime = registrationTime;
        //}

        //public QuizReport(int id, int score, DateTime registrationTime)
        //{
        //    Id = id;
        //    Score = score;
        //    RegistrationTime = registrationTime;
        //}
    }
}
