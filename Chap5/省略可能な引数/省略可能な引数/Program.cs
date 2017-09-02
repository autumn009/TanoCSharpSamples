using System;

class Program
{
    private static void sample(int a = 1, int b = 2)
    {
        Console.WriteLine("{0},{1}", a, b);
    }

    static void Main(string[] args)
    {
        sample();
        sample(3);
        sample(3, 4);
    }
}
