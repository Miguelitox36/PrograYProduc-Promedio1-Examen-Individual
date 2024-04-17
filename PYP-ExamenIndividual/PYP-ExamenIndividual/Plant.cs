using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_ExamenIndividual
{
    public class Plant : IsAlive
    {
        public int Fruits {  get; set; }
        public int SeedValue { get; set; }
        public int ProductValue { get; set; }

        public Plant(string name, int timeoflife) : base(name, timeoflife) 
        { 

        }
    }
}
