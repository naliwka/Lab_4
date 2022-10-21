using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_2
{
    internal class VetClinic 
    {
        Animals animal1;
        Animals animal2;
        Animals animal3;  
        public Animals Animal1
        {
            set { animal1 = value; }
        }
        public Animals Animal2
        {
            set { animal2 = value; }
        }
        public Animals Animal3
        {
            set { animal3 = value; }
        }
        public VetClinic(Animals animal1)
        {            
            this.animal1 = animal1; 
        }
        public VetClinic(Animals animal1, Animals animal2) 
        {
            this.animal1 = animal1;
            this.animal2 = animal2;
        }
        public VetClinic(Animals animal1, Animals animal2, Animals animal3) 
        {
            this.animal1 = animal1;
            this.animal2 = animal2;
            this.animal3 = animal3;
        }
        public virtual void PropertiesInConsole()
        {
            Type t = typeof(VetClinic);
            Console.WriteLine($"Class {t.Name}:");
            foreach (var prop in t.GetProperties())
                Console.WriteLine($"\t{prop.Name} ({prop.PropertyType.Name})");
        }
    }
}
