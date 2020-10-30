using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Worksheet3
{
    class Program
    {
        static void Main(string[] args)
        {
            //since magazine/book is inheriting from Publication, magazine can be considered to be a publication,
            //therefore we can initialse a Magazine and store it in a publication variable
            Publication p = new Publication();
            Publication b = new Book();
            Publication m = new Magazine();
        }
    }
}
