//Write a program that finds the greatest of given 5 variables.


using System;
using System.Linq;

class GreatestOfFiveNumbers
{
    static void Main()
    {
        int[] numbers = { 3, 9, 5, 6, 2 };
        int biggestNumber = numbers.Max();
        Console.WriteLine(biggestNumber);
    }
}

