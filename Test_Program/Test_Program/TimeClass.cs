﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    class TimeClass
    {
        public TimeClass()
        {
            _time = DateTime.Now;
        }

        private DateTime _time;

        public string ShowTime()
        {
            return _time.ToString();
        }
    }
}
