using System;

class X
{
    public string A { get; }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new X();
        a.A = "Hello";
        a.A += "World";
        Console.WriteLine(a.A);
    }
}
