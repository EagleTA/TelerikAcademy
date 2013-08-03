//Sort 3 real values in descending order using nested if statements.


using System;

class DescendingOrder
{
    static void Main()
    {
        int a = 14;
        int b = 1;
        int c = 10;
        int helpVar;
        if (b > a)
        {
            helpVar = a;
            a = b;
            b = helpVar;
            if (c > b)
            {
                helpVar = c;
                c = b;
                b = helpVar;
            }
            if (b > a)
            {
                helpVar = a;
                a = b;
                b = helpVar;
            }
        }
        if (c > b)
        {
            helpVar = c;
            c = b;
            b = helpVar;
            if (b > a)
            {
                helpVar = a;
                a = b;
                b = helpVar;
            }
        }
        Console.WriteLine("Sequence of digits: {0}, {1}, {2}", a, b, c);
    }
}