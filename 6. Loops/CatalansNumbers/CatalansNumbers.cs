//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula

using System;
using System.Numerics;

class CatalansNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int nNumber = int.Parse(Console.ReadLine());
        BigInteger factorielN = 1, productN = 1;   

        for (int i = 0; i < nNumber; i++)       
        {
            productN = factorielN = 1;
            for (int j = 1; j < i; j++)          
            {
                productN *= (j + 1 + i);
                factorielN *= j + 1;
            }
            Console.WriteLine("C({1}) = {0}", productN / factorielN, i);
        }
    }
}