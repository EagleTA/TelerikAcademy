using System;

class FindTheBit
{
    static void Main()
    {
        int a = 3;
        int b = 227;
        int mask = 1 << a;
        int bAndMask = b & mask;
        int bit = bAndMask >> a;
        Console.WriteLine("The bit is " + bit);
    }
}
