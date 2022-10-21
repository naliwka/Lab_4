using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Lab_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cats cat = new Cats();
            Dogs dog = new Dogs();
            Horses horse = new Horses();
            Animals animals = new Animals();
            var enteredAnimals = new List<Animals>();
            Console.WriteLine("Enter your name and surname:");
            animals.OwnerName = Console.ReadLine();
            Console.WriteLine($"Enter the animals through the space (only numbers)");
            Console.WriteLine($"1 - cat\n2 - dog\n3 - horse");
            string enteredNumbers = Console.ReadLine();
            int i = enteredNumbers.Split(' ').Length;
            foreach (string number in enteredNumbers.Split(' '))
            {
                int num = Convert.ToInt32(number);
                switch (num)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the name of a cat:");
                            cat.NameCat = Console.ReadLine();
                            Console.WriteLine("Enter the breed of a cat:");
                            cat.BreedCat = Console.ReadLine();
                            enteredAnimals.Add(cat);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the name of a dog:");
                            dog.NameDog = Console.ReadLine();
                            Console.WriteLine("Enter the breed of a dog:");
                            dog.BreedDog = Console.ReadLine();
                            enteredAnimals.Add(dog);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the name of a horse:");
                            horse.NameHorse = Console.ReadLine();
                            Console.WriteLine("Enter the breed of a horse:");
                            horse.BreedHorse = Console.ReadLine();
                            enteredAnimals.Add(horse);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Entered incorrect number");
                            break;
                        } 
                }
            }
            if (i == 1)
            {
                VetClinic patients = new VetClinic(enteredAnimals[0]);
            }
            else if (i == 2)
            {
                VetClinic patients = new VetClinic(enteredAnimals[0], 
                    enteredAnimals[1]);
            }
            else if (i == 3)
            {
                VetClinic patients = new VetClinic(enteredAnimals[0], 
                    enteredAnimals[1],
                    enteredAnimals[2]);
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Properties:");
            animals.PropertiesInConsole();
            cat.PropertiesInConsole();
            dog.PropertiesInConsole();
            horse.PropertiesInConsole();
        }
    }
}
