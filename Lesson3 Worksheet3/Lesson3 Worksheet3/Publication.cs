﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Worksheet3
{
    class Publication
    {
        public string Title { get; set; }
        public int Copies { get; set; }
        public  double Price { get; set; }

        public int SetCopy(int ammount)
        {
            Copies -= ammount;
            return Copies;
        }
    }
}
