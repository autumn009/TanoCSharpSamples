using System;

class Program
{
    static void Main(string[] args)
    {
        string[] array = { "1", "2", "3", "4" };
        foreach (var s in array)
        {
            if (s == "3") return;
            Console.WriteLine(s);
        }
    }
}

