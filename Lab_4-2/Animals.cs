using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab_4_2
{
    internal class Animals
    {
        private string ownerName;
        public string OwnerName
        {
            set
            {
                ownerName = value;  
            }
        }
        public virtual void PropertiesInConsole()
        {
            Type t = typeof(Animals);
            Console.WriteLine($"Class {t.Name}:");
            foreach (var prop in t.GetProperties())
                Console.WriteLine($"\t{prop.Name} ({prop.PropertyType.Name})");
        }
    }
}
