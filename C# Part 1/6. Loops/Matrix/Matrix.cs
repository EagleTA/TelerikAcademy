//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
//    N = 3			N = 4


// Нарочно не съм решил последните две задачи, които са със звездичка. Те не са задължителни.

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 20)
        {
            int i = 1;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = i; j <= i + (n - 1); j++)
                {
                    Console.Write(j + " ");
                }
            } Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Must be < 20");
        }
    }
}