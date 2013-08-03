using System;

class CalculateTheCircle
{
    static void Main()
    {
        int x = 4;
        int y = -4;
        int centerX = 0;
        int centerY = 5;
        
        bool result = (((x - centerX)*(x - centerX)) + ((y - centerY)*(y - centerY)) < 5*5 );

        Console.WriteLine(result);
    }
}

