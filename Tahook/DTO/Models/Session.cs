using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahook.DTO.Model
{
    public class Session
    {
        public int Id { get; set; }

        public string PinCode { get; set; }

        public DateTime Start { get; set; }

        public DateTime Stop { get; set; }
    }
}
