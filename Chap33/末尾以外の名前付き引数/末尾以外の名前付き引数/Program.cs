using System;

class Program
{
    private static void sub(string s, string t)
    {
        Console.WriteLine($"{s} {t}");
    }

    static void Main(string[] args)
    {
        sub(s: "Hello", "World");
    }
}
