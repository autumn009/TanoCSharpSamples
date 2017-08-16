using System;

public class A
{
}

public class B : A
{
    public void sub() => Console.WriteLine("in sub");
}

class Program
{
    private static void anyTypeSampleMethod<T>(T para)
        where T : A
    {
        if (para is B b1) b1.sub();

        switch (para)
        {
            case B b2: b2.sub(); break;
        }
    }
    static void Main(string[] args)
    {
        anyTypeSampleMethod(new B());
    }
}

