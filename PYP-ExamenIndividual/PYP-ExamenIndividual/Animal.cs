using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PYP_ExamenIndividual
{
    public class Animal : IsAlive, IReproducible
    {
        public int Products { get; set; }
        private static int counterBreed = 0;
        public int PurchaseValue { get; set; }

        public Animal(string name, int timeoflife) : base(name, timeoflife) 
        { 

        }

        public void Breed() 
        {
            int result = Fibonacci(counterBreed);
            Products += result;
            counterBreed++;
        }

        private int Fibonacci(int n)
        { 
            if (n <= 1) 
            {
                return n;
            }
            else 
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
