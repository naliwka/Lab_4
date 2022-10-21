using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_4
{
    internal class Program
    {
        // Створіть клас ApplicationLicense.
        // У тілі класу створіть три методи AllowTrial(), AllowCommon(), AllowPro().
        // У тіло кожного з відповідних методів додайте виведення на екран відповідних рядків:
        // "Триальний режим", "Безкоштовна версія", "Платна версія".
        // За необхідності створюйте похідні класи та перевизначте відповідні методи.
        // У тілі методу Main() реалізуйте можливість прийому від користувача номер ключа доступу trial і pro.
        // Якщо користувач не вводить ключ, він може користуватися тільки безкоштовною версією,
        // якщо користувач ввів номери ключа доступу pro і trial -
        // йому відкривається повний або урізаний доступ до програми.
        // За будь-яких дій користувача, які стосуються роботи програми -
        // перевіряйте та виводьте його рівень доступу.
        static void Main(string[] args)
        {
            ApplicationLicense applicationLicense;
            Console.WriteLine("Введіть ключ: ");
            applicationLicense = new ApplicationLicense(Console.ReadLine());
        }
    }
}
