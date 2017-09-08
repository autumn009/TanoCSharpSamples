using System;

partial class A
{
    public void MyMethod()
    {
        Console.WriteLine("in A:MyMethod1");
    }
}

partial class A
{
    public void MyMethod()
    {
        Console.WriteLine("in A:MyMethod2");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var x = new A();
        x.MyMethod();
    }
}
