//Напишете програма, която отпечатва на конзолата числата от 1 до N, 
//които не се делят едновременно на 3 и 7. Числото N да се чете от стандартния вход.


using System;


class NumbersToNSecond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            if (i % 21 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

