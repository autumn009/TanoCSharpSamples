using System;

class Program
{
    private const string x = "!";
    private static string a = x && throw new ApplicationException();

    static void Main(string[] args)
    {
        Console.WriteLine(a);
    }
}
