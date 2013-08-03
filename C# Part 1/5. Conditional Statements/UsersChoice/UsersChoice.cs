//Write a program that, depending on the user's 
//choice inputs int, double or string variable. If the variable is
//integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.


using System;

class UsersChoice
{
    static void Main()
    {
        Console.Write("Write 0 for int, 1 for double, 2 for string:");
        int variable = int.Parse(Console.ReadLine());
        switch (variable)
        {
            case 0:
                Console.Write("Write a int variable :");
                int variableInteger = int.Parse(Console.ReadLine());
                Console.WriteLine(" {0}", variableInteger + 1);
                break;
            case 1:
                Console.Write("Write a double variable :");
                double variableDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(" {0} ", variableDouble + 1);
                break;
            case 2:
                Console.Write("Write a string variable :");
                string variableString = (Console.ReadLine());
                Console.WriteLine(" {0}", variableString + "*");
                break;
        }
    }
}
