using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Accountant : Person
    {
        byte Timeworked;
        public decimal TotalPay { get; }
        public Accountant(string name, byte timeworked) : base(name, 45000)
        {

            Timeworked = timeworked;
            decimal payPerDay = MonthlySalary / Settings.WorkTimeInMonth;
            decimal totalPay = 0;
            totalPay += payPerDay * Timeworked;
            TotalPay = Math.Round(totalPay);



        }
    }
}
