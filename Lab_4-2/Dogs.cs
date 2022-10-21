using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_2
{
    internal class Dogs : Animals
    {
        string breedDog;
        string nameDog;
        public string BreedDog 
        { 
            get 
            { 
                return breedDog; 
            }
            set
            {
                breedDog = value;
            }
        }
        public string NameDog 
        { 
            get 
            { 
                return nameDog; 
            } 
            set 
            { 
                nameDog = value; 
            }
        }   
        public override void PropertiesInConsole()
        {
            Type t = typeof(Dogs);
            Console.WriteLine($"Class {t.Name}:");
            foreach (var prop in t.GetProperties())
                Console.WriteLine($"\t{prop.Name} ({prop.PropertyType.Name})");
        }
    }
}
