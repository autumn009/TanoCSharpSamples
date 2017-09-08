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
    private static void SayGreeting(object x)
    {
        x.GetType().InvokeMember("SayGreeting",
            BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
            null,
            x,
            null);
    }
    static void Main(string[] args)
    {
        var a = new A();
        var b = new B();
        SayGreeting(a);
        SayGreeting(b);
    }
}
