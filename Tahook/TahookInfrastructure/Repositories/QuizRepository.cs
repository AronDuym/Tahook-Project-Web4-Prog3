using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.DTO.Contracts;
using Tahook.DTO.Model;

namespace Tahook.Infrastructure.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly TahookContext _dbcontext;

        public QuizRepository(TahookContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void QuizCreate(Quiz quiz)
        {
            _dbcontext.Quiz.Add(quiz);
            _dbcontext.SaveChanges();
        }

        public void QuizDelete(Quiz quiz)
        {
            _dbcontext.Quiz.Remove(quiz);
            _dbcontext.SaveChanges();
        }

        public Quiz? QuizGetById(int id)
        {
            Quiz? quiz= _dbcontext.Quiz.FirstOrDefault(x => x.Id == id);
            return quiz;
        }

        public Task<Quiz?> QuizGetByIdAsync(int id)
        {
            return _dbcontext.Quiz.FirstOrDefaultAsync(x => x.Id == id);
        }

        public List<Quiz> QuizGetGuizzesByGameTopic(GameTopic gameTopic)
        {
            List<Quiz> quizzes = _dbcontext.Quiz.Where(x => x.GameTopic.Id == gameTopic.Id).ToList();
            return quizzes;
        }

        public Task<List<Quiz>> QuizGetGuizzesByGameTopicAsync(GameTopic gameTopic)
        {
            return _dbcontext.Quiz.Where(x => x.GameTopic.Id == gameTopic.Id).ToListAsync();
        }

        public void QuizUpdate(Quiz quiz)
        {
            _dbcontext.Quiz.Update(quiz);
            _dbcontext.SaveChanges();
        }

        public List<Quiz> QuizzesGetAll()
        {
            List<Quiz> quizzes = _dbcontext.Quiz.ToList();
            return quizzes;
        }

        public Task<List<Quiz>> QuizzesGetAllAsync()
        {
            return _dbcontext.Quiz.ToListAsync();
        }
    }
}
