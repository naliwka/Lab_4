using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab_4_3
{
    internal class Family
    {       
        private string surname;
        public string Surname
        {
            get { return surname; } 
            set { this.surname = value; }
        }
        public Family()
        {
            
        }
        public virtual void PropertiesInDebug()
        {
            Type t = typeof(Family);
            Debug.WriteLine($"The class {t.Name} type has the following properties: ");
            foreach (var prop in t.GetProperties())
                Debug.WriteLine($"\t{prop.Name} ({prop.PropertyType.Name})");
        }
        public virtual void WriteInfo(object objectFamily)
        {
            Family family = (Family)objectFamily;   
            Console.WriteLine($"{family.Surname}'s family includes mum, dad and son.");
        }
    }
}
