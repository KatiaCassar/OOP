using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SavingsAccount mySavingsAccount = new SavingsAccount(); //created an instance of SavingsAccount. name of instance: mySavingsAccount
            mySavingsAccount.Iban = "6587246587";

            mySavingsAccount.Balance = 1234;
            mySavingsAccount.InterestRate = 5;
            double interestInEuros = mySavingsAccount.CalculateInterest();
            */

            User myUser = new User();
            myUser.IdCard = "7643497";
            myUser.Name = "Joe";
            myUser.Surname = "Borg";
            //BankAccount b = new BankAccount("7564785348568", 100, myUser);
            SavingsAccount s = new SavingsAccount("7564785348568", 100, myUser, 1.5);

            double updatedBalance = s.Withdraw(100);
        }
    }
}
