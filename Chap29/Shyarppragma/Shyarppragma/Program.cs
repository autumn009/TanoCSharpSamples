using System;

class Program
{
    [Obsolete]
    private static void A()
    {
        Console.WriteLine("I'm Obsoleted");
    }

    static void Main(string[] args)
    {
        A();
    }
}

