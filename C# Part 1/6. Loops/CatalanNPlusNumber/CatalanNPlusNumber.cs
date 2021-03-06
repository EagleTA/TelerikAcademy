﻿//Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;

class CatalanNPlusNumber
{
    static void Main()
    {
        BigInteger catalanNumber;
        Console.Write("Enter N: ");
        uint n = uint.Parse(Console.ReadLine());  
  
        catalanNumber = 1;
        for (uint i = 2 * n; i > 1; i--)
        {
            if (i > n + 1)
            {
                catalanNumber *= i;
            }
            else if (i <= n)
            {
                catalanNumber /= i;
            }
        }

        Console.WriteLine("Catalan number for n = {0} is {1}\n", n, catalanNumber);
    }
}

