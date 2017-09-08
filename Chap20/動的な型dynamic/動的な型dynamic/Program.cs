using System;

public class A
{
    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}

class Program
{
    static void Main(string[] args)
    {
        dynamic d = new A();
        d.SayGoodbye();
    }
}
