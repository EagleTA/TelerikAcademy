//Write a program that, for a given two integer numbers N and X,
//calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN


using System;

class XandNProblem
{
    static void Main()
    {
        Console.Write("Enter N: ");
        double nNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter X :");
        double xNumber = double.Parse(Console.ReadLine());

        double sum = 1;
        double power;
        int factorial = 1;
        for (int k = 0; k <= nNumber; k++)
        {
            factorial *= k;
            power = Math.Pow(xNumber, nNumber);
            sum += (factorial / power);
        }Console.WriteLine(sum);
    }
}
