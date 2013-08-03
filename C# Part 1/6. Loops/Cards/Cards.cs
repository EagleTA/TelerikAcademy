//Write a program that prints all possible cards from 
//a standard deck of 52 cards (without jokers). The cards should be printed with their English names.
//Use nested for loops and switch-case.


using System;

class Cards
{
    static void Main()
    {
        int cards =  14;
        int color = 4;

        for (int h = 1; h <= color; h++)
        {
            switch (h)
            {   
                case 1:
                    Console.WriteLine("Spades");
                    break;
                case 2:
                    Console.WriteLine("Hearts");
                    break;
                case 3:
                    Console.WriteLine("Diamonds");
                    break;
                case 4:
                    Console.WriteLine("Clubs");
                    break;
            }
            
            for (int i = 2; i <= cards; i++)
            {
                switch (i)
                {
                    case 2:
                        Console.WriteLine(" 2");
                        break;
                    case 3:
                        Console.WriteLine(" 3");
                        break;
                    case 4:
                        Console.WriteLine(" 4");
                        break;
                    case 5:
                        Console.WriteLine(" 5");
                        break;
                    case 6:
                        Console.WriteLine(" 6");
                        break;
                    case 7:
                        Console.WriteLine(" 7");
                        break;
                    case 8:
                        Console.WriteLine(" 8");
                        break;
                    case 9:
                        Console.WriteLine(" 9");
                        break;
                    case 10:
                        Console.WriteLine(" 10");
                        break;
                    case 11:
                        Console.WriteLine(" Jack");
                        break;
                    case 12:
                        Console.WriteLine(" Queen");
                        break;
                    case 13:
                        Console.WriteLine(" King");
                        break;
                    case 14:
                        Console.WriteLine(" Ace");
                        break;
                }
            } Console.WriteLine();
        }
    }
}

