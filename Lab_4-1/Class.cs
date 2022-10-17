using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Lab_4_1
{
    public class Class : BaseClass
    {
        internal override void WriteParameters(string stringPar, int intPar, double doublePar)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(stringPar.GetType());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(intPar.GetType());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(doublePar.GetType());
        }
    }
}
