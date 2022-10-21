using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab_4_2
{
    internal class Horses : Animals
    {
        string breedHorse;
        string nameHorse;
        public string BreedHorse 
        { 
            get 
            { 
                return breedHorse; 
            } 
            set 
            { 
                breedHorse = value; 
            } 
        }
        public string NameHorse
        {
            get 
            { 
                return nameHorse; 
            }
            set
            {
                nameHorse = value;
            }
        }
        public override void PropertiesInConsole()
        {
            Type t = typeof(Horses);
            Console.WriteLine($"Class {t.Name}:");
            foreach (var prop in t.GetProperties())
                Console.WriteLine($"\t{prop.Name} ({prop.PropertyType.Name})");
        }        
    }
}
