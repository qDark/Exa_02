﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1
{
    class OP
    {
        public double x;

        public OP(double x)
        {

            this.x = x;

        }

        public static double operator +(OP a, OP b)
        {
            return a.x * 3.78 + b.x;
        }

        public static double operator -(OP a, OP b)
        {
            return a.x * 3.78 - b.x;
        }
    }
}
