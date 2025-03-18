﻿// See https://aka.ms/new-console-template for more information

using challenge.challengesClass;

int chooseValue = 0;

do
{
    Console.WriteLine("Choose an option:");
  
    Console.WriteLine("[00] - Exit");
    Console.WriteLine("[01] - Sum two numbers");
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
    Console.WriteLine("[12] - Guess number");
    Console.WriteLine("[13] - Vehicle financing");
    Console.WriteLine("[14] - Retirement");
    Console.WriteLine("[15] - Tic-tac-toe");

    Console.Write("Option:");
    chooseValue = Convert.ToInt32(Console.ReadLine());

    switch (chooseValue)
    {
        case 0:
            Console.WriteLine("Thank you! Good bye.");
            break;
        case 1:
            sum();
            break;
        case 2:
            metersToMillimeter();
            break;
        case 3:
            calculateIncrease();
            break;
        case 4:
            calculateDiscount();
            break;
        case 5:
            carRental();
            break;
        case 6:
            calculateBmi();
            break;
        case 7:
            break;
        case 8:
            multiplicationTable();
            break;
        case 9:
            multiplesOf3();
            break;
        case 10:
            factorials();
            break;
        case 11:
            incomeTax();
            break;
        case 12:
            guessNumber();
            break;
        case 13:
            vehicleFinacing();
            break;
        case 14:
            retirement();
            break;
        case 15:
            ticTacToe();
            break;
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadLine();
    Console.Clear();


} while (chooseValue != 0);

void sum()
{

    Console.Write("Enter a number:");
    var value1 = Console.ReadLine();
    Console.Write("Enter another number:");
    var value2 = Console.ReadLine();    

    if(int.TryParse(value1, out var intValue1) && int.TryParse(value2, out var intValue2))
    {
        Console.WriteLine("Result: " + SumTwoNumbers.Sum(intValue1, intValue2));
    }
    else
    {
        Console.WriteLine("Values ​​must be int numbers.");
    }

}

void metersToMillimeter()
{

}

void calculateIncrease()
{

}

void calculateDiscount()
{

}

void carRental()
{

}

void calculateBmi() 
{

}

void multiplicationTable()
{

}

void multiplesOf3()
{

}

void factorials()
{

}

void incomeTax()
{

}

void guessNumber()
{

}

void vehicleFinacing()
{

}

void retirement()
{

}

void ticTacToe()
{

}