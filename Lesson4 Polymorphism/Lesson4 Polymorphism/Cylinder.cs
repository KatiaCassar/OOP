using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Polymorphism
{
    class Cylinder : Circle
    {
        public double Length { get; set; }

        public Cylinder(int x, int y, double radius, double length) : base(x, y, radius)
        {
            Length = length;
        }

        public override double FindArea()
        {
            return (2 * Math.PI * Radius *Length) + (2 * Math.PI * Math.Pow(Radius, 2));
        }
    }
}
