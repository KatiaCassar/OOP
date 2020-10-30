using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Worksheet3
{
    class Magazine : Publication
    {
        public int  CurrIssue { get; set; }
        public int OrderQty { get; set; }

        //This method should accept the amount of the new order quantity as a parameter. For functionality, this amount should replace the current orderQty.
        public void AdjustQty(int amount)
        {
            OrderQty = amount;
        }

        //This method should simply increses the currIsuues attribute
        public void RecNewIssue()
        {
            CurrIssue++;
        }
    }
}
