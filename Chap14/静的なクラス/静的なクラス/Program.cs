using System;

static class A
{
    internal static int B = 123;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(A.B);
    }
}
