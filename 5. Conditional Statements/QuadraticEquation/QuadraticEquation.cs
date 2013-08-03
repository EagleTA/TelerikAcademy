//Write a program that enters the coefficients a, b and c of a quadratic equation
//        a*x2 + b*x + c = 0
//        and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;


class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());
        double D = (b * b) - (4 * a * c);
        if (a == 0)
        {
            double x0 = (-c) / b;
            Console.WriteLine("One root: {0}", x0);
        }
        else if (D < 0)
        {
            Console.WriteLine("No real roots");
        }
        else if (D == 0)
        {
            double x0 = (-b) / (2 * a);
            Console.WriteLine("The root is: {0}", x0);
        }
        else if (D > 0)
        {
            double x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
            double x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("The roots are: x1={0} and x2={1}", x1, x2);
        }
        else
        {
            Console.WriteLine("Try again");
        }
    }
}

