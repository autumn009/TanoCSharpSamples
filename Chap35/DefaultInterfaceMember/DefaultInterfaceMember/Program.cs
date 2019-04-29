using System;

interface ISample
{
    void Sub1();
    void Sub2() => Console.WriteLine("in Sub2");
    void Sub3() => Console.WriteLine("in Sub3");
}

class Inherited : ISample
{
    public void Sub1() => Console.WriteLine("in Sub1");
    public void Sub3() => Console.WriteLine("in Sub3 (Inherites)");
}

class Program
{
    static void Main()
    {
        Inherited a = new Inherited();
        a.Sub1();
        //a.Sub2();
        a.Sub3();
        ISample b = a as ISample;
        b.Sub2();
    }
}
