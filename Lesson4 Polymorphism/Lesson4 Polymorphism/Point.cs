using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Polymorphism
{
    // Static Polymorphism is when you overload the constructor/methods
    // Dynamic Polymorphism
    //  1. When you declair a method and you allow the inherited classes to change the method's implemenation
    //  2. The ability to choose the proper method of the created instance
    class Point
    {
        public Point()
        {
            //constructor's main role is to internally opan a memory space inside your RAM and
            //once that memory location is open then you can start storing/reading values
            X = 0;
            Y = 0;
        }

        public Point (int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a point.");
        }

        public void Drae(int x , int y)
        {
            Console.WriteLine($"Drawing a point at {x}, {y}");
        }
    }
}
