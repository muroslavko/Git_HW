﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    class Square
    {
		double pi;
		
		public Square()
		{
			pi = 3.14;
		}
		
        public double Circle(double r)
        {
            return 2 * Math.PI * r;
        }
    }
}
