using System;


class R1 { }
class R2 : R1 { }

abstract class A
{
    public abstract R1 Sub();
}

class B : A
{
    public override R2 Sub()
    {
        Console.WriteLine("B.Sub");
        return null;
    }
}

class Program
{
    static void Main()
    {
        var a = new B();
        R2 r2 = a.Sub();
    }
}
