using System;

class A
{
    public int X = 123;
    public A()
    {
        X = 456;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new A() { X = 789 };
        Console.WriteLine(a.X);
    }
}
