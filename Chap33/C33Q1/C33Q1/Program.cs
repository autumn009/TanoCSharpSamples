using System;

struct X
{
    internal int Y;
}

class Program
{
    private static void sub(in X x)
    {
        Console.WriteLine(x.Y++);
    }
    static void Main(string[] args)
    {
        var a = new X();
        a.Y = 123;
        sub(in a);
    }
}
