using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Polymorphism_Worksheet4
{
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Hello! I am a dog.");
        }
    }
}
