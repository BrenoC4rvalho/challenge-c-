// See https://aka.ms/new-console-template for more information

int chooseValue = 0;

do
{
    Console.WriteLine("Choose an option:");
  
    Console.WriteLine("[00] - Exit");
    Console.WriteLine("[01] - Add two numbers");
    Console.WriteLine("[02] - Convert meters to millimeters");
    Console.WriteLine("[03] - Calculate increase");
    Console.WriteLine("[04] - Calculate discount");
    Console.WriteLine("[05] - Car rental");
    Console.WriteLine("[06] - Calculate bmi");
    Console.WriteLine("[07] - ");
    Console.WriteLine("[08] - Multiplication table for each number");
    Console.WriteLine("[09] - Multiples of 3 between 0 and 100");
    Console.WriteLine("[10] - Factorials from 1 to 10");
    Console.WriteLine("[11] - Income tax");
    Console.WriteLine("[12] - Gess number");
    Console.WriteLine("[13] - Vehicle financing");
    Console.WriteLine("[14] - Retirement");
    Console.WriteLine("[15] - Tic-tac-toe");

    Console.Write("Option:");
    chooseValue = Convert.ToInt32(Console.ReadLine());

    switch (chooseValue)
    {
        case 0:
            break;
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            break;
        case 8:
            break;
        case 9:
            break;
        case 10:
            break;
        case 11:
            break;
        case 12:
            break;
        case 13:
            break;
        case 14:
            break;
        case 15:
            break;
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadLine();
    Console.Clear();


} while (chooseValue != 0);