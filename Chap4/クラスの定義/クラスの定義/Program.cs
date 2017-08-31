using System;

class A
{
    private int a;
    public void Method()
    {
        Console.WriteLine(a);
    }
    public A(int a)
    {
        this.a = a;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var x = new A(123);
        x.Method();
    }
}
