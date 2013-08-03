using System;

class HelloString
{
    static void Main(string[] args)
    {
        string helloString = "Hello";
        Console.WriteLine(helloString);
        string worldString = "World!";
        Console.WriteLine(worldString);
        object helloWorldObject = helloString + " " + worldString;
        Console.WriteLine(helloWorldObject);
        string helloWorldString = Convert.ToString(helloWorldObject);
        Console.WriteLine(helloWorldString);
    }
}
