using System;

class Program
{
    private static void sample<T>(object a)
    {
        Console.WriteLine(a is T);
    }
    static void Main(string[] args)
    {
        sample<string>("hello");
    }
}
