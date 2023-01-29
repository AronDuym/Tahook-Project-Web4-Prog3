using Microsoft.EntityFrameworkCore;
using Tahook.DTO.Contracts;
using Tahook.DTO.Model;

namespace Tahook.Infrastructure.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly TahookContext _dbcontext;

        public QuestionRepository(TahookContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void QuestionCreate(Question question)
        {
            _dbcontext.Question.Add(question);
            _dbcontext.SaveChanges();
        }

        public void QuestionDelete(Question question)
        {
            _dbcontext.Question.Remove(question);
            _dbcontext.SaveChanges();
        }

        public Question? QuestionGetByDescription(string description)
        {
            Question? question = _dbcontext.Question.FirstOrDefault(x => x.Description == description);
            return question;
        }

        public Task<Question?> QuestionGetByDescriptionAsync(string description)
        {
            return _dbcontext.Question.FirstOrDefaultAsync(x => x.Description == description);
        }

        public Question? QuestionGetById(int id)
        {
            Question? question = _dbcontext.Question.FirstOrDefault(x => x.Id== id);
            return question;
        }

        public Task<Question?> QuestionGetByIdAsync(int id)
        {
            return _dbcontext.Question.FirstOrDefaultAsync(x => x.Id == id);
        }

        public List<Question> QuestionsGetAll()
        {
            List<Question> questions = _dbcontext.Question.ToList();
            return questions;
        }

        public Task<List<Question>> QuestionsGetAllAsync()
        {
            return _dbcontext.Question.ToListAsync();
        }

        public List<Question> QuestionsGetByQuiz(Quiz quiz)
        {
            List<Question> questions = _dbcontext.Question.Where(x => x.Quiz.Id ==quiz.Id).ToList();
            return questions;
        }

        public Task<List<Question>> QuestionsGetByQuizAsync(Quiz quiz)
        {
            return _dbcontext.Question.Where(x => x.Quiz.Id==quiz.Id).ToListAsync();
        }

        public void QuestionUpdate(Question question)
        {
            _dbcontext.Question.Update(question);
            _dbcontext.SaveChanges();
        }
    }
}
