using System;

class Program
{
    static void Main(string[] args)
    {
        string a = "Hello!";
        Console.WriteLine(a is object);
        Console.WriteLine(a is string);
    }
}
