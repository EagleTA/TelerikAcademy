//Write a program that calculates N!/K! for given N and K (1<K<N).


using System;
using System.Numerics;

class NAndKFactorials
{
    static void Main()
    {
        Console.Write("vavedi N:");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("vavedi K:");
        int numberK = int.Parse(Console.ReadLine());

        if (numberN > 1 && numberK > numberN)
        {
            var factorialN = new BigInteger(1);
            for (var i = 1; i <= numberN; i++)
            {
                factorialN *= i;
            }
            Console.WriteLine("Factorial n = {0}", factorialN);

            var factorialK = new BigInteger(1);
            for (var j = 1; j <= numberK; j++)
            {
                factorialK *= j;
            }
            Console.WriteLine("Factorial k = {0}", factorialK);

            var nAndK = new BigInteger(1);
            nAndK = factorialN/factorialK;
            Console.WriteLine("N!/K!={0}", nAndK);
        }
        else
        {
            Console.WriteLine("N > 1 and K > N");
        }
    }
}

