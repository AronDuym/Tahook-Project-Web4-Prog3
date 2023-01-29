namespace Tahook.DTO.Model
{
    public class Question
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public int DurationTime { get; set; }

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }

        public List<Answer> Answers { get; set; }

        //public Question(int id, string description, bool isActive, int durationTime, Quiz quiz, List<Answer> answers)
        //{
        //    Id = id;
        //    Description = description;
        //    IsActive = isActive;
        //    DurationTime = durationTime;
        //    Quiz = quiz;
        //}

        //public Question(int id, string description, bool isActive, int durationTime)
        //{
        //    Id = id;
        //    Description = description;
        //    IsActive = isActive;
        //    DurationTime = durationTime;
        //}
    }
}
