using System;

class Program
{
    private static void a(int y)
    {
        y = 456;
        Console.WriteLine("yは{0}です。", y);
    }

    static void Main(string[] args)
    {
        int x = 123;
        a(x);
        Console.WriteLine("xは{0}です。", x);
    }
}

