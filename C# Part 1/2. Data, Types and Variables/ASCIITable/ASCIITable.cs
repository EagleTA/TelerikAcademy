﻿using System;

class ASCIITable
{

    static void Main()
    {
        for (int i = 0; i <= 255; i++)
        {
            System.Console.WriteLine("{0} = {1}", i, (char)i);
        }
    }
}
