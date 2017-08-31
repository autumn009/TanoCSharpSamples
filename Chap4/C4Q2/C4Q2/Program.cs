using System;

internal class A
{
    X static int b = 123;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(A.b);
    }
}
