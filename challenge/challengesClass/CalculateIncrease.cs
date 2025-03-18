using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class CalculateIncrease
    {
        public static void Calculate()
        {
            try
            {
                Console.Write("Enter the current salary (R$): ");
                double currentSalary = double.Parse(Console.ReadLine());

                Console.Write("Enter the percentage increase (%): ");
                double percentageIncrease = double.Parse(Console.ReadLine());

                double increaseAmount = currentSalary * (percentageIncrease / 100);
                double newSalary = currentSalary + increaseAmount;

                Console.WriteLine("\nSalary Increase Details:");
                Console.WriteLine($"Initial Salary: R$ {currentSalary:F2}");
                Console.WriteLine($"Percentage Increase: {percentageIncrease:F2}%");
                Console.WriteLine($"Increase Amount: R$ {increaseAmount:F2}");
                Console.WriteLine($"New Salary: R$ {newSalary:F2}");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
        }
    }
}
