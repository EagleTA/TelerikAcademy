//Write a program that reads a number N and calculates the sum of the first N members of 
//the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.


using System;

class FibonacciSum
{
    static void Main()
    {
        Console.Write("Vavedi chislo :");
        int number = int.Parse(Console.ReadLine());

        Console.Write("0 1");
        int previous = 0;
        int next = 1;
        for (int i = 0; i <= number; i++)
        {
            int sum = next + previous;
            previous = next;
            next = sum;
            Console.Write(" " + next);
        } Console.WriteLine();
    }
}
