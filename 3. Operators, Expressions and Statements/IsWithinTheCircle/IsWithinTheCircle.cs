using System;

class IsWithinTheCircle
{
    static void Main()
    {
        double x = 2;
        double y = 2;
        double r = 3;

    if ( ((x-1) * (x-1)) * ((y - 1) * (y - 1)) <=  r * r)
        {
            if (y  > 1 && y < 4)
            {
                Console.WriteLine("In the circle and out of the triangle.");
            }else if  (y  < -1 && y > -2 )
            {
                Console.WriteLine("In the circle and out of the triangle.");
            }else if ((y > -1 && y < 1) && (x > -2 && x < -1))
            {
                Console.WriteLine("In the circle and out of the triangle.");
            }else
            {
                Console.WriteLine("Try again");
            }
        }else
        {
            Console.WriteLine("Not even in the circle");
        }           
    }
}
