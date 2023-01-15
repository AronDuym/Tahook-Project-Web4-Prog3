using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.Domain.Model
{
    public class Session
    {
        public string PinCode { get; set; }

        public DateTime Start { get; set; }

        public DateTime Stop { get; set; }
    }
}
