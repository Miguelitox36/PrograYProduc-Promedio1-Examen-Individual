using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PYP_ExamenIndividual
{
    public class Farm
    {
        private List<Plant> plants; 
        private List<Animal> animals;
        private int moneyInitial;
        private int spacesAvailable;
        private int priceSpace;

        private List<int> GenerateSeriesPrime(int limit)
        {
            List<int> primes = new List<int>();
            for (int x = 2; primes.Count < limit; x++)
            {
                bool isPrime = true;

                for (int y = 2; y <= Math.Sqrt(x); y++)
                {
                    if (x % y == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(1);
                }
            }            

            return primes;
        }

        public Farm(int moneyInitial)
        {
            this.moneyInitial = moneyInitial;
            this.animals = new List<Animal>();
            this.plants = new List<Plant>();
            this.spacesAvailable = 1;
            this.priceSpace = 10;
        }

        public void ExpandFarm() 
        {
            if (moneyInitial >= priceSpace)
            {
                moneyInitial -= priceSpace;
                spacesAvailable++;
                priceSpace += 10; 
                Console.WriteLine("Expanded farm! Now you have " + spacesAvailable + " spaces.");
            }
            else
            {
                throw new Invalid("You don't have enough money to expand the farm.");
            }
        }

        public void BuySeed(Plant plant) 
        {
            if (moneyInitial >= plant.SeedValue)
            {
                moneyInitial -= plant.SeedValue;
                plants.Add(plant);
                Console.WriteLine("Seed purchased successfully!");
            }
            else
            {
                throw new Invalid("You don't have enough money to buy this seed.");
            }
        }

        public void BuyAnimal(Animal animal) 
        {
            if (moneyInitial >= animal.PurchaseValue)
            {
                moneyInitial -= animal.PurchaseValue;
                animals.Add(animal);
                Console.WriteLine("Animal purchased successfully!");
            }
            else
            {
                throw new Invalid("You don't have enough money to buy this animal.");
            }
        }

        public void PassShift()
        {
            Console.WriteLine("Last turn! Checking farm...");
            Harvest();
        }

        public void Harvest() 
        {
            foreach (Plant planta in plants)
            {
                int quantityProducts = CalculateQuantityProducts(planta);
                Console.WriteLine("Harvesting " + quantityProducts + " plant products " + planta.Name);
                moneyInitial += quantityProducts * planta.ProductValue;
            }

            foreach (Animal animal in animals)
            {
                animal.Breed();
                Console.WriteLine("Reproducing animal " + animal.Name + ". New products: " + animal.Products);
            }
        }

        private int CalculateQuantityProducts(Plant plant)
        {
            List<int> primes = GenerateSeriesPrime(plant.Timeoflife);
            int quantityProducts = 0;
            for (int i = 0; i < plant.Timeoflife; i++)
            {
                quantityProducts *= primes[i];
            }

            return quantityProducts;
        }   
    }
}
