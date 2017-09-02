using System;

class Program
{
    static void Main(string[] args)
    {
        short a1 = 4649;
        var a2 = 4649;
        Console.WriteLine(a1.GetType().FullName);
        Console.WriteLine(a2.GetType().FullName);
    }
}
