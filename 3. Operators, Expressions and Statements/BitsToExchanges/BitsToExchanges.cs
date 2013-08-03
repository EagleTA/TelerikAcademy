//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class Program
{
    static void Main()
    {
        int number = 9;


        int mask = 1 << 3;
        int thirdBit = (number & mask) >> 3;

        mask = 1 << 24;
        int twentyFourthBit = (number & mask) >> 24;

        if (thirdBit == 0)
        {
            mask = ~(1 << 24);
            number = number & mask;
        }
        else if (thirdBit == 1)
        {
            mask = 1 << 24;
            number = number | mask;
        }

        if (twentyFourthBit == 0)
        {
            mask = ~(1 << 3);
            number = number & mask;
        }
        else if (twentyFourthBit == 1)
        {
            mask = 1 << 3;
            number = number | mask;
        }

        Console.WriteLine(number);
    }
}

/*  -------- 4-25 --------
  int mask = 1 << 4;
        int thirdBit = (number & mask) >> 4;

        mask = 1 << 25;
        int twentyFourthBit = (number & mask) >> 25;

        if (thirdBit == 0)
        {
            mask = ~(1 << 25);
            number = number & mask;
        }
        else if (thirdBit == 1)
        {
            mask = 1 << 25;
            number = number | mask;
        }

        if (twentyFourthBit == 0)
        {
            mask = ~(1 << 4);
            number = number & mask;
        }
        else if (twentyFourthBit == 1)
        {
            mask = 1 << 4;
            number = number | mask;
        }
  
  
 ------ 5-26-------------
  int mask = 1 << 5;
        int thirdBit = (number & mask) >> 5;

        mask = 1 << 26;
        int twentyFourthBit = (number & mask) >> 26;

        if (thirdBit == 0)
        {
            mask = ~(1 << 26);
            number = number & mask;
        }
        else if (thirdBit == 1)
        {
            mask = 1 << 26;
            number = number | mask;
        }

        if (twentyFourthBit == 0)
        {
            mask = ~(1 << 5);
            number = number & mask;
        }
        else if (twentyFourthBit == 1)
        {
            mask = 1 << 5;
            number = number | mask;
        }
 */