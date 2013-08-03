using System;

class IsNumberPrime
{
    static void Main()
    {
        int number = 37;
        int i;
        for (i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine("The number is not prime."); break;
            }
        } if (i == number)
        {
            Console.WriteLine("The number is prime.");
        }
    }
}
