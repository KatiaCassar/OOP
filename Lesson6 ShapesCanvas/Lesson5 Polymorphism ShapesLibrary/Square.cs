using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Polymorphism_ShapesLibrary
{
    public class Square : Shape
    {
        public double Length { get; set; }
        public Square(int x, int y, double length) : base(x, y)
        {
            Length = length;
        }

        public override double FindPerimeter()
        {
            return 4 * Length;
        }

        public override double FindArea()
        {
            return Length * Length;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.FromName(BorderColor)), X, Y, (float)Length, (float)Length);
        }
    }
}
