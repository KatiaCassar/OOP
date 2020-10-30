using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Polymorphism
{
    class Circle : Point
    {
        public Circle (int x, int y, double radius) :base(x, y)
        {
            //X = x;    //these 2 are ommited because you are taking them from the base constructor using the :base(x, y)
            //Y = y; 
            Radius = radius;
        }
        public double Radius { get; set; }

        public override void Draw()
        {
            // base.Draw();     //this is ommmited to compleately change the method and not the add to it
            Console.WriteLine("Drawig a Circle");
        }

        public virtual double FindArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
