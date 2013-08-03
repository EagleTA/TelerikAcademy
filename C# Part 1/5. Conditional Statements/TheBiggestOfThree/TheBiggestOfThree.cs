//Write a program that finds the biggest of three integers using nested if statements.


using System;

class TheBiggestOfThree
{
    static void Main()
    {
        Console.Write("Enter a number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter a second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter a third number:");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is:" + " " + firstNumber);
        }
        else
        {
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The biggest number is:" + " " + secondNumber);
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine("The biggest number is:" + " " + thirdNumber);
            }
        }
    }
}

