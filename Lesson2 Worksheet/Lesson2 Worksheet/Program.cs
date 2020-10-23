using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Worksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            //object (instance) ->> object is when you create a space in memory and start assigning values to the template you created earlier
            Circle c = new Circle(5, "black"); //eg. of ac object --> c
            
            c.Radius = 5;

            Console.WriteLine("Input a radius: ");
            c.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Area is {c.GetArea()}");
            Console.WriteLine($"Perimeter is {c.GetPerimeter()}");

            Console.WriteLine($"Press a key to terminate");
            Console.ReadKey();
        }
    }
}
