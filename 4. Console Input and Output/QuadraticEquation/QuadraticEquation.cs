//Write a program that reads the coefficients a, b and c of 
//a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter A:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter B:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter C:");
        int c = int.Parse(Console.ReadLine());

        double D = (b * b) - 4 * (a * c);

        if (D > 0)
        {
            double x1 = ((-b) + (Math.Sqrt(D))) / 2;
            double x2 = ((-b) - (Math.Sqrt(D))) / 2;
            Console.WriteLine("X1 is {0} and X2 is {1}", x1, x2);
        }
        else if (D == 0)
        {
            double x1And2 = (-b) / (2 * a);
            Console.WriteLine("X is {0}", x1And2);
        }
        else
        {
            Console.WriteLine("There's no x ");
        }
    }
}
