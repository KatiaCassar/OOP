using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Inheritance
{
    //inheritance: that the class in question is inheriting/getting all the public/protected members/properties/methods of the base class 
    class SavingsAccount : BankAccount //all public properties are inherited
    {
        public SavingsAccount(string iban, double balance, User owner, double interestRate):base(iban, balance, owner)
        {
            InterestRate = interestRate;
        }

        public double InterestRate { get; set; }

        public double CalculateInterest()
        {
            return Balance * (InterestRate / 100);
        }
    }
}
