//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.


using System;

class BiggerNumber
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int numberA = int.Parse(Console.ReadLine());

        Console.Write("Enter second number:");
        int numberB = int.Parse(Console.ReadLine());

        int thirdNumber = numberA - numberB;
        int fourthNumber = (thirdNumber >> 31) & 1;
        int maxNum = numberA - (fourthNumber * thirdNumber);

        Console.WriteLine(maxNum);
    }
}

