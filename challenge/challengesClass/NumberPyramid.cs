using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class NumberPyramid
    {
        public static void Execute()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int line = 1; line <= n; line++)
            {
                for (int column = 1; column <= line; column++)
                {
                    Console.Write(column);
                }
                Console.WriteLine();
            }
        }
    }
}
