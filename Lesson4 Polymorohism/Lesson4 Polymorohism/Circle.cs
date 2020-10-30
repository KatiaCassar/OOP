using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Polymorohism
{
    public class Circle : Point
    {
        public Circle(int x, int y, double radius) : base(x, y)
        {
            //X = x;    //these two where ommited because they inherite these properies from the :base(x, y)
            //Y = y;
            Radius = radius;
        }

        public double Radius { get; set; }


        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }

        public virtual double FindArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
