using System;

class Program
{
    private static void sample()
    {
        Console.WriteLine("QX");
    }

    static void Main(string[] args)
    {
        Action act = sample;
        act();
    }
}
