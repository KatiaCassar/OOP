using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Polymorphism_Worksheet4
{
    public class Employee
    {
        public Employee()
        {}

        public  string Name { get; set; }
        public double BasePay { get; set; }
        public string IdCard { get; set; }

        public virtual double CalculateTotalPay ()
        {
            return BasePay;
        }

        //getting the hash code of the id card
        public override int GetHashCode()
        {
            return IdCard.GetHashCode();
        }

        //to check if a person if duplicated by using the hash code of the id card
        public override bool Equals(object obj)
        {
            if(this.GetHashCode()== obj.GetHashCode())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
