using System;
class Program
{
    private static (string a, string b) sub()
    {
        return ("one", "two");
    }

    static void Main(string[] args)
    {
        (string name1, string name2) = sub();
        Console.WriteLine(name1);
        Console.WriteLine(name2);
    }
}

