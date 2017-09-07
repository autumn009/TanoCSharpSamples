using System;

public class A
{
    public virtual void Sample()
    {
        Console.WriteLine("in class A");
    }
}

public class B : A
{
    public override void Sample()
    {
        Console.WriteLine("in class B");
        base.Sample();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        A x = new B();
        x.Sample();
    }
}
