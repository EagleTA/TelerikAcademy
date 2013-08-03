using System;

class TwoStrings
{
    static void Main()
    {
        string withQuotes = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(withQuotes);

        withQuotes = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(withQuotes);
    }
}