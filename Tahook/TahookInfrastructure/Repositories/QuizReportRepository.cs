using Microsoft.EntityFrameworkCore;
using Tahook.DTO.Contracts;
using Tahook.DTO.Model;

namespace Tahook.Infrastructure.Repositories
{
    public class QuizReportRepository : IQuizReportRepository
    {
        private readonly TahookContext _dbcontext;

        public QuizReportRepository(TahookContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void QuizReportCreate(QuizReport quizReport)
        {
            _dbcontext.QuizReport.Add(quizReport);
            _dbcontext.SaveChanges();
        }

        public void QuizReportDelete(QuizReport quizReport)
        {
            _dbcontext.QuizReport.Remove(quizReport);
            _dbcontext.SaveChanges();
        }

        public List<QuizReport> QuizReportGetByAnswer(Answer answer)
        {
            List<QuizReport> quizReports = _dbcontext.QuizReport.Where(x => x.Answer.Id == answer.Id).ToList();
            return quizReports;
        }

        public Task<List<QuizReport>> QuizReportGetByAnswerAsync(Answer answer)
        {
            return _dbcontext.QuizReport.Where(x => x.Answer.Id == answer.Id).ToListAsync();
        }

        public QuizReport? QuizReportGetById(int id)
        {
            QuizReport? quizReport = _dbcontext.QuizReport.FirstOrDefault(x => x.Id == id);
            return quizReport;
        }

        public Task<QuizReport?> QuizReportGetByIdAsync(int id)
        {
            return _dbcontext.QuizReport.FirstOrDefaultAsync(x => x.Id == id);
        }

        public List<QuizReport> QuizReportGetByQuestion(Question question)
        {
            List<QuizReport> quizReports = _dbcontext.QuizReport.Where(x => x.Question.Id== question.Id).ToList();
            return quizReports;
        }

        public Task<List<QuizReport>> QuizReportGetByQuestionAsync(Question question)
        {
            return _dbcontext.QuizReport.Where(x => x.Question.Id == question.Id).ToListAsync();
        }

        public List<QuizReport> QuizReportGetByUser(User user)
        {
            List<QuizReport> quizReports = _dbcontext.QuizReport.Where(x => x.User.Id== user.Id).ToList();
            return quizReports;
        }

        public Task<List<QuizReport>> QuizReportGetByUserAsync(User user)
        {
            return _dbcontext.QuizReport.Where(x => x.User.Id == user.Id).ToListAsync();
        }

        public List<QuizReport> QuizReportsGetAll()
        {
            List<QuizReport> quizReports = _dbcontext.QuizReport.ToList();
            return quizReports;
        }

        public Task<List<QuizReport>> QuizReportsGetAllAsync()
        {
            return _dbcontext.QuizReport.ToListAsync();
        }

        public void QuizReportUpdate(QuizReport quizReport)
        {
            _dbcontext.QuizReport.Update(quizReport);
            _dbcontext.SaveChanges();
        }
    }
}
