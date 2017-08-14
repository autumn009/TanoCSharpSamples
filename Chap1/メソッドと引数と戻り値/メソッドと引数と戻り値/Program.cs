using System;

class Program
{
    private static int abc(int a, int b, int c)
    {
        var result = a * b + c;
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(abc(1, 2, 3));
    }
}
