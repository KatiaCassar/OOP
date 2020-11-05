using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Polymorphism_ShapesLibrary
{
    public class Circle : Shape
    {
        public  double Radius { get; set; }
        public Circle(int x, int y, double radius): base(x, y)
        {
            Radius = radius;
        }
    }
}
