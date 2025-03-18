using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class Retirement
    {

        public static void Calculate()
        {
            try
            {
                Console.Write("Enter your current age: ");
                if (!int.TryParse(Console.ReadLine(), out int currentAge) || currentAge < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive integer for age.");
                    return;
                }

                Console.Write("Enter the age you plan to retire: ");
                if (!int.TryParse(Console.ReadLine(), out int retirementAge) || retirementAge <= currentAge)
                {
                    Console.WriteLine("Invalid input. Retirement age must be greater than current age.");
                    return;
                }

                Console.Write("Enter the amount you intend to save monthly ($): ");
                if (!double.TryParse(Console.ReadLine(), out double monthlySaving) || monthlySaving <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number for monthly savings.");
                    return;
                }

                Console.Write("Enter the monthly return rate (as a percentage, e.g., 1.5 for 1.5%): ");
                if (!double.TryParse(Console.ReadLine(), out double monthlyRate) || monthlyRate < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative number for the return rate.");
                    return;
                }

                monthlyRate /= 100; // Convert percentage to decimal
                int months = (retirementAge - currentAge) * 12;
                double totalAmount = 0;

                // Compound interest calculation
                for (int i = 0; i < months; i++)
                {
                    totalAmount = (totalAmount + monthlySaving) * (1 + monthlyRate);
                }

                // Calculate monthly income after retirement
                double monthlyIncome = totalAmount * monthlyRate;

                Console.WriteLine($"\nTotal accumulated amount: ${totalAmount:F2}");
                Console.WriteLine($"Estimated monthly income after retirement: ${monthlyIncome:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
    }
}
