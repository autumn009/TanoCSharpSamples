using System;
class Program
{
    static void Main(string[] args)
    {
        var a = 0b1111;
        var b = 1_000_000;
        Console.WriteLine(a == 15);
        Console.WriteLine(b == 1000000);
    }
}

