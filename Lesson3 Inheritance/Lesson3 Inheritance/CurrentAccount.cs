using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Inheritance
{
    class CurrentAccount : BankAccount
    {
        public double FeeOnChequeTransaction { get; set; }

        public void ConvertChequeIntoEuros()
        {
            Balance = Balance - FeeOnChequeTransaction;
        }
    }
}
