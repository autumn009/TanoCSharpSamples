using System;

class Program
{
    private static void twotimes(ref int x)
    {
        x = x * 2;
    }

    private static void twotimesWithoutRef(int y)
    {
        y = y * 2;
    }

    static void Main(string[] args)
    {
        int a = 2;
        twotimesWithoutRef(a);
        Console.WriteLine("a={0}", a);
        int b = 2;
        twotimes(ref b);
        Console.WriteLine("b={0}", b);
    }
}
