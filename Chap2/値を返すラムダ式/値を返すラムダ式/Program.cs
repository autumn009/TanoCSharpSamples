using System;

class Program
{
    static void Main(string[] args)
    {
        byte a = 2;
        double b = 3.0;
        int c;
        Func<byte, double, int> f = (x, y) =>
        {
            return (int)(x * y);
        };
        c = f(a, b);
        Console.WriteLine(c);
    }
}
