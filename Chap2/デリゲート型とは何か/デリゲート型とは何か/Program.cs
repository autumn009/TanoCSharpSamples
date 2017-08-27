using System;

delegate void SayIt(string s);

class Program
{
    private static void doit1(string s)
    {
        Console.WriteLine(s + " Everybody");
    }
    private static void doit2(string s)
    {
        Console.WriteLine(s + " World");
    }
    static void Main(string[] args)
    {
        SayIt a = doit1;
        a("Hello");
        a = doit2;
        a("Hello");
    }
}
