using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringPar = "string";
            int intPar = 5;
            double doublePar = 0.9;
            BaseClass class1 = new Class();
            BaseClass baseClass = new BaseClass(); 
            class1.WriteParameters(stringPar, intPar, doublePar);
            baseClass.WriteParameters(stringPar, intPar, doublePar);    
        }
    }
}
