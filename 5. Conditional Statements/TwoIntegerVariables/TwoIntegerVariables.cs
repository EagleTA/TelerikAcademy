//Write an if statement that examines two integer variables and exchanges their values if
//the first one is greater than the second one.


using System;

class TwoIntegerVariables
{
    static void Main()
    {
        int firstNumber = 40;
        int secondNumber = 30;

        if (firstNumber > secondNumber)
        {
            firstNumber ^= secondNumber;
            secondNumber ^= firstNumber;
            firstNumber ^= secondNumber;
            Console.WriteLine("Now first number is {0} and second nnumber is {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("Second number is bigger.");
        }
    }
}