using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Worksheet
{
    class Rectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public double RecPer()
        {
            return (Width * 2) + (Length * 2);
        }

        public double RecArea()
        {
            return Width * Length;
        }
    }
}
