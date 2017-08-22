using System;

class X
{
    ~X()
    {
        Console.WriteLine("Destructed");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new X();
    }
}
