﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationLicense applicationLicense;
            Console.WriteLine("Введіть ключ: ");
            applicationLicense = new ApplicationLicense(Console.ReadLine());
        }
    }
}
