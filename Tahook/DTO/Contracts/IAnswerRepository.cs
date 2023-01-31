using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.DTO.Model;

namespace Tahook.DTO.Contracts
{
    public interface IAnswerRepository
    {
        List<Answer> AnswersGetAll();
        Task<List<Answer>> AnswersGetAllAsync();

        Answer? AnswerGetById(int id);
        Answer? AnswerGetByDescription(string description);
        List<Answer?> AnswersGetByQuestion(Question question);

        Task<Answer?> AnswerGetByIdAsync(int id);
        Task<Answer?> AnswerGetByDescriptionAsync(string description);
        Task<List<Answer?>> AnswersGetByQuestionAsync(Question question);




        void AnswerCreate(Answer answer);
        void AnswerUpdate(Answer answer);
        void AnswerDelete(Answer answer);
        
    }
}
