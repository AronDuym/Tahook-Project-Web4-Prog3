namespace Tahook.DTO.Model
{
    public class Answer
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public string Image { get; set; }

        //public Answer(int id, string description, bool isCorrect, Question question, string image)
        //{
        //    Id = id;
        //    Description = description;
        //    IsCorrect = isCorrect;
        //    //Question = question;
        //    Image = image;
        //}

        //public Answer(int id, string description, bool isCorrect, string image)
        //{
        //    Id = id;
        //    Description = description;
        //    IsCorrect = isCorrect;
        //    Image = image;
        //}
    }
}
