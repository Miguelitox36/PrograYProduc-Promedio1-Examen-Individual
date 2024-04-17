using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_ExamenIndividual
{
    public abstract class IsAlive
    {
        public string Name { get; set; }
        public int Timeoflife { get; set; }

        public IsAlive(string name, int timeoflife)
        {
            Name = name;
            Timeoflife = timeoflife;           
        }
    }
}
