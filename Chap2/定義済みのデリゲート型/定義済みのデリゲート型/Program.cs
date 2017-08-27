using System;

class Program
{
    private static void doit(Action<string> sayit)
    {
        sayit("Hello");
    }
    static void Main(string[] args)
    {
        Action<string> say = (s) => Console.WriteLine(s);
        Action<string> sayWithParen = (s) => Console.WriteLine("(" + s + ")");
        doit(say);
        doit(sayWithParen);
    }
}
