using PYP_ExamenIndividual;
using System;

class Program
{
    static void Main(string[] args)
    {

        Farm farm = new Farm(100);

        bool continuePlay = true;
        while(continuePlay) 
        {
            Console.WriteLine("What action do you want to take?");
            Console.WriteLine("1. Expand the farm");
            Console.WriteLine("2. Buy Seed");
            Console.WriteLine("3. Buy Animals");
            Console.WriteLine("4. Pass Shift");
            Console.WriteLine("5. Exit Game");

            string option = Console.ReadLine();

            if(option != null)
            {
            
             switch (option)
             {
                case "1":

                    try
                    {
                        farm.ExpandFarm();
                    }

                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine($"ERROR: " + ex.Message);
                    }
                    break;
                case "2":

                    try
                    {
                        Plant plant = new Plant("Plant Name", 10);
                        farm.BuySeed(plant);
                    }

                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }
                    break;
                case "3":
                    try
                    {
                        Animal animal = new Animal("Animal Name", 15);
                        farm.BuyAnimal(animal);
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }
                    break;
                case "4":
                    farm.PassShift();
                    break;
                case "5":
                    continuePlay = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
             }

            }

            else 
            {
                Console.WriteLine("Error: An error occurred while reading the entry.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        
        }

        Console.WriteLine("Thanks for playing!!");
    }
}