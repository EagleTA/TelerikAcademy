//Write an expression that extracts from a given integer 
//i the value of a given bit number b. Example: i=5; b=2  value=1.

using System;

class ExtractsFromAGivenInteger
{
    static void Main()
    {
        int number = 5;
        int position = 2;

        int mask = 1 << position;
        int result = mask & number;
        result = result >> position;
        Console.WriteLine(result);
    }
}