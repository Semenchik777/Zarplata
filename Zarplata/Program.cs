using Domain;
using Storage;
using System;
using System.Collections.Generic;

namespace Zarplata
{
    class Program
    {
        static void Main(string[] args)
        { 
            Director director = new Director("Петя Масло",23);
            Accountant accountant = new Accountant("Раиса Измайлова", 22);
            Manager manager = new Manager("Ольга А", 20);
            Security security = new Security("Аут", 18);
            Console.WriteLine($"{director.Name}\t{director.TotalPay}");
            Console.WriteLine($"{accountant.Name}\t{accountant.TotalPay}");
            Console.WriteLine($"{manager.Name}\t{manager.TotalPay}");
            Console.WriteLine($"{security.Name}\t{security.TotalPay}");
            Console.ReadLine();
        }
    }
}
 