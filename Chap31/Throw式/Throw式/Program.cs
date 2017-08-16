using System;

class Program
{
#if DEBUG
    private const string x = "!";
#else
    private const string x = null;
#endif
    private static string a = x ?? throw new ApplicationException();

    static void Main(string[] args)
    {
        Console.WriteLine(a);
    }
}

