using System;

class X
{
    public int A { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new X();
        a.A = 123;
        Console.WriteLine(a.A);
    }
}
