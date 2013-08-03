using System;

class TwoIntegers
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        
        a ^= b;
        b ^= a;
        a ^= b;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
