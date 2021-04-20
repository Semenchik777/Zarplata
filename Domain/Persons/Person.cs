using System;

namespace Domain
{
    public class Person
    {
              
        public string Name { get;}

        public Person(string name)
        {
            Name = name;
        }
        public decimal MonthlySalary { get;}
        public Person(string name,decimal monthlysalary)
        {
            MonthlySalary = monthlysalary;
        }
    }
}
