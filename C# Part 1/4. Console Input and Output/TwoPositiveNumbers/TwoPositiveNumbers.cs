//Write a program that reads two positive integer numbers and prints how many 
//numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). 
//Example: p(17,25) = 2.


using System;

class TwoPositiveNumbers
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        int numbers = 0;

        if (firstNumber > 0 && secondNumber > 0)
        {
            for (int p = firstNumber; p <= secondNumber; p++)
            {
                if (p % 5 == 0)
                {
                    numbers++;
                }
            } Console.WriteLine("{0} numbers can be divide by 5 between first and second number", numbers);
        }
        else
        {
            Console.WriteLine("Write positive numer!");
        }
    }
}
