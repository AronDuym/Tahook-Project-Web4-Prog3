using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.Infrastructure
{
    public class TahookDataInitialiser
    {
        TahookContext TahookContext_context = new TahookContext();

        public TahookDataInitialiser(TahookContext tahookContext_context)
        {
            TahookContext_context = tahookContext_context;
        }

        public async Task InitializeData()
        {
            //TODO
        }
    }
}
