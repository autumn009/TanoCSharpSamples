using System;

class Program
{
    static void Main(string[] args)
    {
        object s = "Hello!";
        Console.WriteLine(((string)s).ToUpper());
    }
}
