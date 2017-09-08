using System;

partial class A
{
    public void MyMethod1()
    {
        Console.WriteLine("in A:MyMethod1");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var x = new A();
        x.MyMethod1();
        x.MyMethod2();
    }
}
