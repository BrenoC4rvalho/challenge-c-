using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class MultiplesOf3
    {
        public static void Multiples()
        {
            Console.WriteLine("Multiples of 3 between 0 and 100:");
            for (int i = 0; i <= 100; i += 3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
