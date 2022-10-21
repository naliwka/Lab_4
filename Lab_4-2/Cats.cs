using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_2
{
    internal class Cats : Animals
    {
        string breedCat;
        string nameCat;
        public string BreedCat 
        { 
            get 
            { 
                return breedCat; 
            }
            set
            {
                breedCat = value;
            }
        }
        public string NameCat 
        { 
            get 
            { 
                return nameCat; 
            } 
            set
            {
                nameCat = value;
            }
        }
        public override void PropertiesInConsole()
        {
            Type t = typeof(Cats);
            Console.WriteLine($"Class {t.Name}:");
            foreach (var prop in t.GetProperties())
                Console.WriteLine($"\t{prop.Name} ({prop.PropertyType.Name})");
        }
    }
}
