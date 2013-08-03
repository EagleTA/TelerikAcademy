using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        int number = 63852;
        int newNumber = number / 100;
        int isSevenNumber = newNumber % 10;
        if (isSevenNumber == 7)
        {
            Console.WriteLine("Third digit is 7.");
        }
        else
        {
            Console.WriteLine("Third digit is not 7.");
        }
    }
}
