using Tahook.DTO.Model;

namespace Tahook.DTO.Contracts
{
    public interface IQuestionRepository
    {
        List<Question> QuestionsGetAll();
        Task<List<Question>> QuestionsGetAllAsync();

        Question? QuestionGetById(int id);
        Question? QuestionGetByDescription(string description);

        Task<Question?> QuestionGetByIdAsync(int id);
        Task<Question?> QuestionGetByDescriptionAsync(string description);

        List<Question> QuestionsGetByQuiz(Quiz quiz);
        Task<List<Question>> QuestionsGetByQuizAsync(Quiz quiz);

        void QuestionCreate(Question question);
        void QuestionUpdate(Question question);
        void QuestionDelete(Question question);
        
    }
}
