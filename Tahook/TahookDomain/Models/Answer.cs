namespace Tahook.Domain.Model
{
    public class Answer
    {
        public string Description { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public string Image { get; set; }

        public Answer(string description, bool isCorrect, int questionId, Question question, string image)
        {
            Description = description;
            IsCorrect = isCorrect;
            QuestionId = questionId;
            Question = question;
            Image = image;
        }

        public Answer() { }
    }
}
