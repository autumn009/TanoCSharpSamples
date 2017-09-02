using System;

class Program
{
    private static void twotimes(int a, out int b)
    {
        b = a * 2;
    }

    static void Main(string[] args)
    {
        int r;
        twotimes(2, out r);
        Console.WriteLine(r);
    }
}
