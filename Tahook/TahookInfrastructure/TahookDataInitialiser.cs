using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (!_dbcontext.Quiz.Any())
            {
                //TODO







                _dbcontext.SaveChanges();
            }
        }
    }
}
