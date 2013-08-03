//Write a program that shows the sign (+ or -) of the product of three real numbers
//without calculating it. Use a sequence of if statements.


using System;

class TheSign
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double thirdNumber = double.Parse(Console.ReadLine());
        int sign = 0;

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("Try again without 0.");
        }
        else if (firstNumber < 0)
        {
            sign++;
        }
        else if (secondNumber < 0 )
        {
            sign++;
        }
        else if (thirdNumber < 0)
        {
            sign++;
        }
        if (sign == 3 || sign == 1)
        {
            Console.WriteLine("Sign is: -");
        }
        else
        {
            Console.WriteLine("Sign is: +");
        }
    }
}
