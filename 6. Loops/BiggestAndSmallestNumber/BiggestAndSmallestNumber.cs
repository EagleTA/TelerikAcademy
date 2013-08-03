//Напишете програма, която чете от конзолата поредица от 
//цели числа и отпечатва най-малкото и най-голямото от тях.


using System;
using System.Linq;

class BiggestAndSmallestNumber
{
    static void Main()
    {
        int large, small;
        int[] a = new int[50];

        Console.Write("Numbers count:");
        int numbersCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbersCount; i++)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());
            a[i] = input;
        }
        Console.Write("");
        large = a[0];
        small = a[0];
        for (int i = 1; i < numbersCount; i++)
        {
            if (a[i] > large)
                large = a[i];
            else if (a[i] < small)
                small = a[i];
        }
        Console.WriteLine("Largest {0}", large);
        Console.WriteLine("Smallest {0}", small);

    }
}

