using System;

class MyAge
{
    static void Main()
    {
        int age;
        Console.Write("Write your age: ");
        int.TryParse(Console.ReadLine(), out age);
        Console.Write("Your age after 10 years will be: ");
        int newAge = age + 10;
        Console.WriteLine(newAge);
    }
}