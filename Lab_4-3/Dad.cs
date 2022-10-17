using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_3
{
    internal class Dad : Family
    {
        private string name;
        private string hobby;
        public string Name
        {
            get { return name; }
        }
        public string Hobby
        {
            get { return hobby; }
        }
        public Dad(string name, string hobby)
        {
            this.name = name;
            this.hobby = hobby;
        }
        public override void PropertiesInDebug()
        {
            Type t = typeof(Dad);
            Debug.WriteLine($"The class {t.Name} type has the following properties: ");
            foreach (var prop in t.GetProperties())
                Debug.WriteLine($"\t{prop.Name} ({prop.PropertyType.Name})");
        }
        public override void WriteInfo(object objectFamily)
        {
            Dad dad = (Dad)objectFamily;
            Console.WriteLine($"Dad's name is {dad.Name} and he likes to {dad.Hobby}");
        }           
    }
}
