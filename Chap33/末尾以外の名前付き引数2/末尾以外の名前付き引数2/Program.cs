using System;

class Program
{
    private static void sub(int n, string t)
    {
        Console.WriteLine("In sub(int n, string t)");
    }

    private static void sub<T>(T s, string t)
    {
        Console.WriteLine("In sub<T>(T s, string t)");
    }

    static void Main(string[] args)
    {
        int a = 0;
        sub(s: a, "");
        sub(n: a, "");
    }
}
