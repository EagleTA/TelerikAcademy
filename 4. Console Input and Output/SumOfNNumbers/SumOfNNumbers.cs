//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter number:");
        int number = int.Parse(Console.ReadLine());
        int sumOfNumbers = 0;
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Enter number {0}:", i);
            int numbers = int.Parse(Console.ReadLine());
            sumOfNumbers = sumOfNumbers + numbers;
        }
        Console.WriteLine("The sum is {0}:", sumOfNumbers);
    }
}

