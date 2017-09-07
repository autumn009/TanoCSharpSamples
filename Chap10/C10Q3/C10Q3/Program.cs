using System;

class A
{
    public virtual void MyMethod()
    {
        Console.WriteLine("in A:MyMethod");
    }
}

sealed class B : A
{
    public override void MyMethod()
    {
        Console.WriteLine("in B:MyMethod");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var x = new B();
        x.MyMethod();
    }
}
