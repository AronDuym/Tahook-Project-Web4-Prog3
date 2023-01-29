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
    public class AnswerRepository : IAnswerRepository
    {
        private readonly TahookContext _dbcontext;

        public AnswerRepository(TahookContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void AnswerCreate(Answer answer)
        {
            _dbcontext.Answer.Add(answer);
            _dbcontext.SaveChanges();
        }

        public void AnswerDelete(Answer answer)
        {
            _dbcontext.Answer.Remove(answer);
            _dbcontext.SaveChanges();
        }

        public Answer? AnswerGetByDescription(string description)
        {
            Answer? answer = _dbcontext.Answer.FirstOrDefault(x => x.Description== description);
            return answer;
        }

        public Task<Answer?> AnswerGetByDescriptionAsync(string description)
        {
            return _dbcontext.Answer.FirstOrDefaultAsync(x => x.Description== description);
        }

        public Answer? AnswerGetById(int id)
        {
            Answer? answer = _dbcontext.Answer.FirstOrDefault(x => x.Id == id);
            return answer;
        }

        public Task<Answer?> AnswerGetByIdAsync(int id)
        {
            return _dbcontext.Answer.FirstOrDefaultAsync(x => x.Id== id);
        }

        public List<Answer> AnswersGetAll()
        {
            return _dbcontext.Answer.ToList();
        }

        public Task<List<Answer>> AnswersGetAllAsync()
        {
            return _dbcontext.Answer.ToListAsync();
        }

        public void AnswerUpdate(Answer answer)
        {
            _dbcontext.Answer.Update(answer);
            _dbcontext.SaveChanges();
        }
    }
}
