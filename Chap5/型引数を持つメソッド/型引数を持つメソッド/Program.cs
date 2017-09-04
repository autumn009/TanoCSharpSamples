using System;

class Program
{
    private static string Sample<T>(T p)
    {
        return p.ToString();
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Sample<int>(1234));
        Console.WriteLine(Sample(5678));
    }
}
