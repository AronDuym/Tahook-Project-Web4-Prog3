using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahook.DTO.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Tahook.Infrastructure
{
    public class TahookDataInitialiser
    {
        private readonly TahookContext _dbcontext;

        public TahookDataInitialiser(TahookContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public void InitializeData()
        {

            if (!_dbcontext.GameTopic.Any())
            {
                for (int i = 0; i < 5; i++)
                {
                    GameTopic gameTopic = new GameTopic() { Description = "Wiskunde" + i, Quizzes = new List<Quiz>() }; 
                    _dbcontext.GameTopic.Add(gameTopic);
                }


                _dbcontext.SaveChanges();
            }
        }
    }
}
