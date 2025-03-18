using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace challenge.challengesClass
{
    class MultiplicationTable
    {
        public static void Multiple(int value)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{value} x {i} = {value * i}");
            }
        }
    }
}
