using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class CarRental
    {
        public static void Calculate()
        {
            try
            {
                const double dailyRate = 95.00;
                const double costPerKm = 0.35;

                Console.Write("Enter the number of rental days: ");
                int rentalDays = int.Parse(Console.ReadLine());

                Console.Write("Enter the initial mileage (km): ");
                double initialKm = double.Parse(Console.ReadLine());

                Console.Write("Enter the final mileage (km): ");
                double finalKm = double.Parse(Console.ReadLine());

                if (finalKm < initialKm)
                {
                    Console.WriteLine("Error: Final mileage cannot be less than initial mileage.");
                    return;
                }

                double distanceDriven = finalKm - initialKm;
                double dailyCost = rentalDays * dailyRate;
                double distanceCost = distanceDriven * costPerKm;
                double totalAmount = dailyCost + distanceCost;

                Console.WriteLine("\nRental Summary:");
                Console.WriteLine($"Days Rented: {rentalDays}");
                Console.WriteLine($"Total Kilometers Driven: {distanceDriven:F2} km");
                Console.WriteLine($"Cost for Daily Rental: $ {dailyCost:F2}");
                Console.WriteLine($"Cost for Distance Driven: $ {distanceCost:F2}");
                Console.WriteLine($"Total Amount to Pay: $ {totalAmount:F2}");

            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
        }
    }
}
