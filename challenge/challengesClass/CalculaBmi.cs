using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class CalculaBmi
    {
        public static void Calculate(double weight, double height)
        {
            double bmi = weight / (height * height);
            Console.WriteLine($"Your BMI is: {bmi:F2}");

            if (bmi < 18.5)
                Console.WriteLine("Underweight");
            else if (bmi < 24.9)
                Console.WriteLine("Normal weight");
            else if (bmi < 29.9)
                Console.WriteLine("Overweight");
            else
                Console.WriteLine("Obesity");
        }
    }
}
