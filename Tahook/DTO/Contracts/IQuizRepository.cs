using Tahook.DTO.Model;

namespace Tahook.DTO.Contracts
{
    public interface IQuizRepository
    {
        List<Quiz> QuizzesGetAll();
        Task<List<Quiz>> QuizzesGetAllAsync();

        Quiz? QuizGetById(int id);
        Task<Quiz?> QuizGetByIdAsync(int id);

        List<Quiz> QuizGetGuizzesByGameTopic(GameTopic gameTopic);
        Task<List<Quiz>> QuizGetGuizzesByGameTopicAsync(GameTopic gameTopic);

        void QuizCreate(Quiz quiz);
        void QuizUpdate(Quiz quiz);
        void QuizDelete(Quiz quiz);


    }
}
