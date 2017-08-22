using System;

class Program
{
    private static string sample(string s)
    {
        return s + " is in sample.";
    }

    static void Main(string[] args)
    {
        Func<string, string> a = sample;
        Console.WriteLine(a("Joe"));
    }
}

