using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Polymorphism_ShapesLibrary
{
    public class Square : Shape
    {
        public double Length { get; set; }
        public Square (int x, int y, double length):base(x, y)
        {
            Length = length;
        }
    }
}
