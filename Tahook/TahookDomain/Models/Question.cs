namespace Tahook.Domain.Model
{
    public class Question
    {

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public int DurationTime { get; set; }

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }

        public List<Answer> Answers { get; set; }

        public Question(string description, bool isActive, int durationTime, int quizId, Quiz quiz, List<Answer> answers)
        {
            Description = description;
            IsActive = isActive;
            DurationTime = durationTime;
            QuizId = quizId;
            Quiz = quiz;
            Answers = answers;
        }

        public Question()
        {
        }
    }
}
