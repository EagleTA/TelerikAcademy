//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CirclesPerimeter
{
    static void Main()
    {
        // 3.14159265359 
        const double pi = 3.14D;
        int radius = int.Parse(Console.ReadLine());

        double area = pi*(radius * radius);
        double perimeter = (2 * pi) * radius;

        Console.WriteLine("The area of cirlce is {0} and the perimeter is {1}",area, perimeter);
    }
}
