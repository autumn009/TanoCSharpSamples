using System;

static class B
{
    public static string ToString(this string s)
    {
        return s.ToUpper();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello".ToString());
    }
}
