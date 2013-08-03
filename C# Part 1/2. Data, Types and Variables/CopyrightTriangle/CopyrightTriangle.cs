using System;

class Program
{
    static void Main()
    {
        char copyRight = '\u00a9';
        byte spaces = 4;
        int spaceCount;
        int cols;
        int rows;

        for (rows = 0; rows < 3 ; rows++)
        {
            spaces--;
            for (spaceCount = 0; spaceCount < spaces; spaceCount++)
            {
                Console.Write(" ");
            }
            for (cols = 0; cols <= rows; cols++)
            {
                Console.Write(copyRight);
            }
            for (cols = 0; cols <= rows - 1; cols++)
            {
                Console.Write(copyRight);
            }            
            Console.WriteLine();
        }
    }
}

