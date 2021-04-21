using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Manager : Person
    {
        byte Timeworked;
        public decimal TotalPay { get; }
        public Manager(string name, byte timeworked) : base(name, 40000)
        {

            Timeworked = timeworked;
            decimal payPerDay = MonthlySalary / Settings.WorkTimeInMonth;
            decimal totalPay = 0;
            totalPay += payPerDay * Timeworked;
            TotalPay = Math.Round(totalPay, 2);



        }

    }
}
