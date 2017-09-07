using System;

class A
{
    public virtual void Method1()
    {
        Console.WriteLine("in A:Method1");
    }
}

class B : A
{
    public override void Method1()
    {
        Console.WriteLine("in B:Method1");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new A();
        var b = new B();
        A c = new B();
        a.Method1();
        b.Method1();
        c.Method1();
    }
}
