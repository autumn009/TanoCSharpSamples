using System;
using System.Linq;

class A
{
    public virtual void SayMyName()
    {
        Console.WriteLine("I'm A.");
    }
}

class B : A
{
    public override void SayMyName()
    {
        Console.WriteLine("I'm B.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        object[] a = { new A(), new B() };
        foreach (var item in a.OfType<A>()) item.SayMyName();
    }
}
