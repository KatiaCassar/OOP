using System;
using System.Collections.Generic;
using System.Drawing;
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

        public override double FindPerimeter()
        {
            return (Length + Width) * 2;
        }

        public override double FindArea()
        {
            return Length * Width;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.FromName(BorderColor)), X, Y, (float)Length, (float)Width);
        }
    }
}
