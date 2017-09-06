using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        Console.WriteLine(a++ == 1 && b++ == 2);
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

