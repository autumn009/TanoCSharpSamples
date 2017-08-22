using System;

class Program
{
    private static void sample(int a, int b, int c)
    {
        Console.WriteLine("{0},{1},{2}", a, b, c);
    }

    static void Main(string[] args)
    {
        sample(1, 2, 3);
        sample(b: 4, a: 5, c: 6);
        sample(7, c: 8, b: 9);
    }
}
