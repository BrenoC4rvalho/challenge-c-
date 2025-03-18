using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class CalculateDiscount
    {
        public static void Calculate()
        {
            try
            {
                Console.Write("Enter the current price of the product (R$): ");
                double currentPrice = double.Parse(Console.ReadLine());

                Console.Write("Enter the discount percentage (%): ");
                double discountPercentage = double.Parse(Console.ReadLine());

                double discountAmount = currentPrice * (discountPercentage / 100);
                double finalPrice = currentPrice - discountAmount;

                Console.WriteLine("\nDiscount Details:");
                Console.WriteLine($"Initial Price: R$ {currentPrice:F2}");
                Console.WriteLine($"Discount Percentage: {discountPercentage:F2}%");
                Console.WriteLine($"Discount Amount: R$ {discountAmount:F2}");
                Console.WriteLine($"Final Price: R$ {finalPrice:F2}");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
        }

    }
}
