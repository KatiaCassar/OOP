using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Inheritance
{
    //enum is a value which has pre-defined values
    public enum AccountStatus { Active, Suspended, Frozen, Disabled, Closed }
    class BankAccount
    {
        //default constructor (is usually also the parameterless constructor)
        public BankAccount()
        {
            Balance = 0;
            OpeningDate = DateTime.Now;
        }

        //also a constructor (with parameters)
        //to force the user to fill this data as soon as the account is created
        public BankAccount(string _iban, double _balance, User _owner) : this() //the :this() is forcing the program to start from the default constructor
        {
            OpeningDate = DateTime.Now;
            Iban = _iban;
            Balance = _balance;
            Owner = _owner;
        }
        public string Iban { get; set; }
        protected double Balance { get; set; } //use protected instead of private ONLY if you want to allow accesss to this particular property from inherited classes
        public User Owner { get; set; }

        public DateTime OpeningDate { get; } //because it is set automatically by the program and no one is allowed to change this date, other from the first constructor
        public DateTime? ClosingDate { get; set; } //value stored inside this property/field can also be null

        public AccountStatus Status { get; set; }

        public double Withdraw(double ammount)
        { 
            //log the withdraw transaction
            if (ammount <= Balance)
            {
                Balance = Balance - ammount;
            }
            return Balance;
        }
        public double Deposit (double ammount)
        {
            Balance += ammount;
            return Balance;
        }
    }
}
