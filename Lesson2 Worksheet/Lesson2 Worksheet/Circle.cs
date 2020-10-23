using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Worksheet
{
    //access modifier - are the level of access to the class and its members
    //eg. Public, Private, Protected
    public class Circle
    {
        //constructor - bears the same name as the class, which is used to create an instance of the class (the object)
        //              secondary objective of construct : it can be used as a normal method
        public Circle(double radius, string colour) // the constructors is like the key to start the class / the key to initialize the object
        {
            Radius = radius; //setting to default values
            Colour = colour;
        }

        public string Colour { get; set; }
        public double Radius { get; set; }

        //public double Radius { get; set; } //property

        /// <summery>
        /// display the radius value of the instance when called
        /// </summery>
        /// <returns></returns>
        
        public string GetRadius()
        {
            return "Radius: " + Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
