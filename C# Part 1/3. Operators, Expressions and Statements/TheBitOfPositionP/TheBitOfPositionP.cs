using System;
class TheBitOfPositionP
{
    static void Main()
    {
        int number = 5;
        int position = 1;

        int mask = 1 << position;
        int result = mask & number;
        result = result >> position;
        if (result == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

