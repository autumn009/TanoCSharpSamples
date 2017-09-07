using System;

class A
{
    public void IamA()
    {
        Console.WriteLine("This is class A!");
    }
}

class B : A
{
    public void IamB()
    {
        Console.WriteLine("This is class B!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var x = new B();
        x.IamA();
        x.IamB();
    }
}
