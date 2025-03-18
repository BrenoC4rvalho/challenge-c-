using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class IRPFCalculator
    {
        public static void Calculate()
        {
            try
            {
                Console.Write("Enter your monthly income (R$): ");
                double income = double.Parse(Console.ReadLine());

                Console.Write("Enter the number of dependents: ");
                int dependents = int.Parse(Console.ReadLine());

                // Deduction per dependent (value used in 2015, adjust if necessary)
                double dependentDeduction = 189.59;
                double taxableIncome = income - (dependents * dependentDeduction);

                double taxRate = 0;
                double deduction = 0;

                if (taxableIncome <= 1903.98)
                {
                    taxRate = 0;
                    deduction = 0;
                }
                else if (taxableIncome <= 2826.65)
                {
                    taxRate = 7.5;
                    deduction = 142.80;
                }
                else if (taxableIncome <= 3751.05)
                {
                    taxRate = 15;
                    deduction = 354.80;
                }
                else if (taxableIncome <= 4664.68)
                {
                    taxRate = 22.5;
                    deduction = 636.13;
                }
                else
                {
                    taxRate = 27.5;
                    deduction = 869.36;
                }

                double taxAmount = (taxableIncome * taxRate / 100) - deduction;
                taxAmount = taxAmount < 0 ? 0 : taxAmount; // IRPF cannot be negative

                Console.WriteLine($"\nYour IRPF to be paid is: R$ {taxAmount:F2}");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
        }
    }
}
