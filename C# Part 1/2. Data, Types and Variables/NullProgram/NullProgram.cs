using System;

class NullProgram
{
    static void Main()
    {
        int? intVariable = null;
        double? doubleVariable = null;
        Console.WriteLine(doubleVariable);
        Console.WriteLine(intVariable);
       // intVariable = 4;
        doubleVariable = 2.3;
        Console.WriteLine(intVariable.GetValueOrDefault());
        Console.WriteLine(doubleVariable);
    }
}
