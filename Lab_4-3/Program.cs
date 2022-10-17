using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Lab_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            family.Surname = "Smith";
            Family mum = new Mum("Margo", "dancing");
            Family dad = new Dad("Bob", "reading books");
            Family son = new Son("Jack", "drawing");
 
            family.WriteInfo(family);
            mum.WriteInfo(mum);
            dad.WriteInfo(dad);
            son.WriteInfo(son);
            
            family.PropertiesInDebug();
            mum.PropertiesInDebug();
            dad.PropertiesInDebug();
            son.PropertiesInDebug(); 
        }
    }
}
