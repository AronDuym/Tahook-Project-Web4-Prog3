using Tahook.DTO.Model;

namespace Tahook.DTO.Contracts
{
    public interface IQuizReportRepository
    {
        List<QuizReport> QuizReportsGetAll();
        Task<List<QuizReport>> QuizReportsGetAllAsync();

        QuizReport? QuizReportGetById(int id);
        Task<QuizReport?> QuizReportGetByIdAsync(int id);

        List<QuizReport> QuizReportGetByQuestion(Question question);
        List<QuizReport> QuizReportGetByAnswer(Answer answer);
        List<QuizReport> QuizReportGetByUser(User user);

        Task<List<QuizReport>> QuizReportGetByQuestionAsync(Question question);
        Task<List<QuizReport>> QuizReportGetByAnswerAsync(Answer answer);
        Task<List<QuizReport>> QuizReportGetByUserAsync(User user);


        void QuizReportCreate(QuizReport quizReport);
        void QuizReportUpdate(QuizReport quizReport);
        void QuizReportDelete(QuizReport quizReport);
    }
}
