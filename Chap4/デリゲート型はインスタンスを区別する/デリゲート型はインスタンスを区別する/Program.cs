using System;

class A
{
    internal string S;
    internal void Say()
    {
        Console.WriteLine(S);
    }
}

class Program
{
    private static void doit(Action sayit)
    {
        sayit();
    }
    static void Main(string[] args)
    {
        A a = new A();
        a.S = "I am one";
        A b = new A();
        b.S = "I am two";
        doit(a.Say);
        doit(b.Say);
    }
}
