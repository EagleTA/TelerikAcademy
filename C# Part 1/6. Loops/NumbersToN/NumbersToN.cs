//Напишете програма, която отпечатва на конзолата числата от 1
//до N. Числото N трябва да се чете от стандартния вход.

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

