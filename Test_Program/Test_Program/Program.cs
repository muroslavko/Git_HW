using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is {0} o'clock",Time());
        }
        static string Time()
        {
            TimeClass time = new TimeClass();
            return time.ShowTime();
        }
    }
}
