using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab_4_1
{
    public class BaseClass
    { 
        virtual internal void WriteParameters(string stringPar, int intPar, double doublePar)
        {
            Debug.WriteLine(message: "String parameter: " + stringPar);
            Debug.WriteLine(message: "Int parameter: " + intPar);
        }
    }
}
