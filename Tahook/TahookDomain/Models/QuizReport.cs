namespace Tahook.Domain.Model
{
    public class QuizReport
    {
        public int Score { get; set; }

        public Question Question { get; set; }

        public Answer Answer { get; set; }

        public User User { get; set; }

        public DateTime RegistrationTime { get; set; }

        public QuizReport(int score, Question question, Answer answer, User user, DateTime registrationTime)
        {
            Score = score;
            Question = question;
            Answer = answer;
            User = user;
            RegistrationTime = registrationTime;
        }
    }
}
