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
                const double valorDiaria = 95.00;
                const double valorPorKm = 0.35;

                Console.Write("Enter the number of rental days: ");
                int diasAlugados = int.Parse(Console.ReadLine());

                Console.Write("Enter the initial mileage (km): ");
                double kmInicial = double.Parse(Console.ReadLine());

                Console.Write("Enter the final mileage (km): ");
                double kmFinal = double.Parse(Console.ReadLine());

                if (kmFinal < kmInicial)
                {
                    Console.WriteLine("Error: Final mileage cannot be less than initial mileage.");
                    return;
                }

                double kmPercorrido = kmFinal - kmInicial;
                double custoDiarias = diasAlugados * valorDiaria;
                double custoKm = kmPercorrido * valorPorKm;
                double totalPagar = custoDiarias + custoKm;

                Console.WriteLine("\nRental Summary:");
                Console.WriteLine($"Days Rented: {diasAlugados}");
                Console.WriteLine($"Total Kilometers Driven: {kmPercorrido:F2} km");
                Console.WriteLine($"Cost for Daily Rental: R$ {custoDiarias:F2}");
                Console.WriteLine($"Cost for Distance Driven: R$ {custoKm:F2}");
                Console.WriteLine($"Total Amount to Pay: R$ {totalPagar:F2}");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
        }
    }
}
