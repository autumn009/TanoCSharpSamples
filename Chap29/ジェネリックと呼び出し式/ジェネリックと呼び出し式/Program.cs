using System;

class Program
{
    private static void Sample<T>(T t)
    {
        Console.WriteLine(t);
    }

    static void Main(string[] args)
    {
        Sample<int>(123);
    }
}
