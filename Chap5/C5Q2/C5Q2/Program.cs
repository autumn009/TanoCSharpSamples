using System;

public class A
{
    public int X;
}

public class Program
{
    public static void Main(string[] args)
    {
        var a = new A();
        var b = a;
        a.X = 123;
        b.X = 456;
        Console.WriteLine(a.X);
    }
}
