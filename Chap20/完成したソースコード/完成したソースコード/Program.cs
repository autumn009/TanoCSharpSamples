using System;
using System.Reflection;

class A
{
    public void SayGreeting()
    {
        Console.WriteLine("クラスAからこんにちは。");
    }
}

class B
{
    public void SayGreeting()
    {
        Console.WriteLine("クラスBからこんにちは。");
    }
}

class Program
{
    private static void SayGreeting(dynamic x)
    {
        x.SayGreeting();
    }
    static void Main(string[] args)
    {
        var a = new A();
        var b = new B();
        SayGreeting(a);
        SayGreeting(b);
    }
}
