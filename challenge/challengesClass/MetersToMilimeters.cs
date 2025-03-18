using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class MetersToMilimeters
    {
        public static void Convert(double value)
        {
            double millimeters = value * 1000;
            Console.WriteLine($"{value} meters is equal to {millimeters} millimeters.");
        }
    }
}
