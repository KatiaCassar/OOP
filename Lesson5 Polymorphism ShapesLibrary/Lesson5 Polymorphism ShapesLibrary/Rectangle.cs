using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Polymorphism_ShapesLibrary
{
    public class Recatngle : Square
    {
        public double Width { get; set; }
        public Recatngle(int x, int y, double length, double width) : base(x, y, length)
        {
            Width = width;
        }
    }
}
