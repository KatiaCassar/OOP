using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Worksheet
{
    class RandomNumbers
    {
        int a { get; set; }
        int b { get; set; }

        public void GenerateNumbers()
        {
            Random r = new Random();

            a = r.Next(1, 10);
            b = r.Next(1, 10);
        }

        public int GetNumber1()
        {
            return a;
        }
        public int GetNumber2()
        {
            return b;
        }

        public int FindSum()
        {
            return a + b;
        }

        public string IsEqual(int a)
        {
            int b = FindSum();

            string isEqualTo;
            if (a == b)
            {
                isEqualTo = "Well done, correct answer!";
            }
            else
            {
                isEqualTo = "Sorry, wrong answer.";
            }

            return isEqualTo;
        }
    }
}
