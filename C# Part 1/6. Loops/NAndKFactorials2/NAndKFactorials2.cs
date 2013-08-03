//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class NAndKFactorials2
{
    static void Main()
    {
        Console.Write("vavedi N:");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("vavedi K:");
        int numberK = int.Parse(Console.ReadLine());
        
            if (numberK > numberN && numberN > 1)
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
                nAndK = factorialN * factorialK;
                Console.WriteLine("N! * K!={0}", nAndK);


                var kMinusN = new BigInteger(numberK - numberN);
                for (var h = 1; h <= kMinusN; h++)
                {
                    kMinusN *= h;
                }
                Console.WriteLine("Factorial k - n = {0}", kMinusN);

                var endResult = nAndK / kMinusN;
                Console.WriteLine("N!*K! / (K-N)! = {0}", endResult);
            }
            else
            {
                Console.WriteLine("N > 1 and K > N ");
            }
        }
    }

