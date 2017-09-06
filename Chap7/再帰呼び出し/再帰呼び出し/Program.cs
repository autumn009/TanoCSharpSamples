using System;
using System.Linq;

class Program
{
    private static void sample(string s)
    {
        if (s.Length == 0) return;
        Console.Write(s.Last());
        sample(s.Substring(0, s.Length - 1));
    }
    static void Main(string[] args)
    {
        sample("rorriM");
    }
}
