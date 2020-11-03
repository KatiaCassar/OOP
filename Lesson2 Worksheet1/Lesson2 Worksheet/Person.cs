using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Worksheet
{
    class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public short Age { get; set; }
        public string Locality { get; set; }
        public string FavColor { get; set; }

        public string GetName()
        {
            return "Name: " + Name;
        }

    }
}
