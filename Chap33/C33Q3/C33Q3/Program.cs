using System;

class Program
{
    private static void sub(int x, int y, int z)
    {
        Console.WriteLine($"{x} {y} {z}");
    }

    static void Main(string[] args)
    {
        sub(y: 1, x: 2, 3);
    }
}
