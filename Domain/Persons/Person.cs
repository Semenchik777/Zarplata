using System;
using System.Collections.Generic;

namespace Domain
{
    public class Person
    {

        
        
       

        public string Name { get;}

        public decimal MonthlySalary { get; }
        
        public Person(string name, decimal monthlysalary)
        {
            Name = name;
            MonthlySalary = monthlysalary;
            

        }


    }
}
