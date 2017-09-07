using System;

abstract class A
{
    public abstract void MyMethod();
}

class B : A
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
        var obj = new B();
        obj.MyMethod();
    }
}
