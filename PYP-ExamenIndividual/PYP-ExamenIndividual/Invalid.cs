using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_ExamenIndividual
{
    public class Invalid : Exception
    {
        public Invalid(string message) : base(message)
        {
        }
    }
}
