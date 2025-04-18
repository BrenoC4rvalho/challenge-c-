﻿// See https://aka.ms/new-console-template for more information

using challenge.challengesClass;

int chooseValue = 0;

do
{
    Console.WriteLine("Choose an option:");
  
    Console.WriteLine("[00] - Exit"); // ok
    Console.WriteLine("[01] - Sum two numbers"); // ok
    Console.WriteLine("[02] - Convert meters to millimeters"); // ok
    Console.WriteLine("[03] - Calculate increase"); // ok
    Console.WriteLine("[04] - Calculate discount"); // ok
    Console.WriteLine("[05] - Car rental"); // ok
    Console.WriteLine("[06] - Calculate bmi");  // ok
    Console.WriteLine("[07] - Number Pyramid");
    Console.WriteLine("[08] - Multiplication table for each number"); // ok
    Console.WriteLine("[09] - Multiples of 3 between 0 and 100"); // ok
    Console.WriteLine("[10] - Factorials from 1 to 10"); // ok
    Console.WriteLine("[11] - Income tax"); // ok
    Console.WriteLine("[12] - Guess number"); // ok
    Console.WriteLine("[13] - Vehicle financing");
    Console.WriteLine("[14] - Retirement"); // ok
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
            numberPyramid();
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
    try
    {
        Console.Write("Enter the value in meters: ");
        var value = Console.ReadLine();
        double.TryParse(value, out var meters);
        MetersToMilimeters.Convert(meters);
    } 
    catch
    {
        Console.WriteLine("Values must be numbers.");
    }
}

void calculateIncrease()
{
    CalculateIncrease.Calculate();
}

void calculateDiscount()
{
    CalculateDiscount.Calculate();
}

void carRental()
{
    CarRental.Calculate();
}

void calculateBmi() 
{
    Console.Write("Enter your weight (kg): ");
    var weightInput = Console.ReadLine();

    Console.Write("Enter your height (m): ");
    var heightInput = Console.ReadLine();

    try
    {
        double.TryParse(weightInput, out var weight); 
        double.TryParse(heightInput, out var height);
        CalculaBmi.Calculate(weight, height);
    }
    catch
    {
        Console.WriteLine("Invalid input. Please enter numeric values for weight and height.");
    }

}

void numberPyramid()
{
    NumberPyramid.Execute();
}

void multiplicationTable()
{
    try
    {
        Console.Write("Enter a number to see its multiplication table: ");
        int num = int.Parse(Console.ReadLine());
        MultiplicationTable.Multiple(num);
    }
    catch
    {
        Console.WriteLine("Values ​​must be int numbers.");
    }


}

void multiplesOf3()
{
    MultiplesOf3.Multiples();
}

void factorials()
{
    Fatorials.GenerateFatorials();
}

void incomeTax()
{
    IRPFCalculator.Calculate();
}

void guessNumber()
{
    GuessNumber.Play();
}

void vehicleFinacing()
{

}

void retirement()
{
    Retirement.Calculate(); 
}

void ticTacToe()
{
    TicTacToe.Main();

}