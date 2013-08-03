//We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//n = 5 (00000101), p=2, v=0  1 (00000001)


using System;

class OperatorsThatModifiesN
{
    static void Main()
    {
        int number = 15;
        int value = 1;
        int position = 3;

        if (value == 0)
        {
            int mask = ~(1 << position);
            int result = number & mask;
            Console.WriteLine(result);
        }
        else if (value == 1)
        {
            int mask = 1 << position;
            int result = number | mask;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("try again");
        }
    }
}

