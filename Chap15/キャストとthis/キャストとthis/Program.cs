using System;

class A
{
    public void MethodA()
    {
        ((B)this).MethodB();
    }
}

class B : A
{
    public void MethodB()
    {
        Console.WriteLine("I'm in methodB!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        A a = new B();
        a.MethodA();
    }
}
