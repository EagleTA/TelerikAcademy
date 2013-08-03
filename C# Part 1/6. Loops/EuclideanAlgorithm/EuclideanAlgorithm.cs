//Write a program that calculates the greatest common divisor (GCD)
//of given two numbers. Use the Euclidean algorithm (find it in Internet).


using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.Write("Vavedi pyrvo chislo: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Vavedi vtoro chislo: ");
        int secondNumber = int.Parse(Console.ReadLine());

        while (firstNumber != secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                firstNumber -= secondNumber;
            }
            else
            {
                secondNumber -= firstNumber;
            }
        } Console.WriteLine("The greatest common divisor is {0}", firstNumber);
    }
}

