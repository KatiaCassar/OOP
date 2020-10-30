using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Inheritance
{
    class FixedTermAccount : BankAccount
    {
        public double Days { get; set; }

        public void SetClosingDate()
        {
            OpeningDate.AddDays(Days);
        }
    }
}
