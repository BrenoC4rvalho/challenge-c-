using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class Fatorials
    {
        public static void GenerateFatorials()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Fatorials to {i} = {CalculateFatorials(i)}");
            }
        }

        private static long CalculateFatorials(int n)
        {
            long fatorials = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorials *= i;
            }
            return fatorials;
        }
    }
}
