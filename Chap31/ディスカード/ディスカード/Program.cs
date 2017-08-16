using System;

class Program
{
    private static (string a, string b) sub()
    {
        return ("one", "two");
    }

    static void Main(string[] args)
    {
        (string name, _) = sub();
        Console.WriteLine(name);
    }
}
