using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Polymorphism_Worksheet4
{
    public class SalesEmployee : Employee
    {

        public double Bonus { get; set; }

        public override double CalculateTotalPay()
        {
            return Bonus + BasePay;
        }
    }
}
