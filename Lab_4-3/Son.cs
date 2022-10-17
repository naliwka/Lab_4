using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_3
{
    internal class Son : Family
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
        public Son(string name, string hobby) 
        {
            this.name = name;
            this.hobby = hobby;
        }
        public override void PropertiesInDebug()
        {
            Type t = typeof(Son);
            Debug.WriteLine($"The class {t.Name} type has the following properties: ");
            foreach (var prop in t.GetProperties())
                Debug.WriteLine($"\t{prop.Name} ({prop.PropertyType.Name})");
        }
        public override void WriteInfo(object objectFamily)
        {
            Son son = (Son)objectFamily;
            Console.WriteLine($"Son's name is {son.Name} and he likes to {son.Hobby}");
        }
    }
}
