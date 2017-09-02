using System;

public class Program
{
    private static void sample(int a, int b, params string[] p)
    {
        Console.Write(a);
        Console.Write(b);
        foreach (var item in p) Console.Write(item);
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        sample(1, 2, "の", "アッホ", "!!");
        sample(3, 4, "郎");
    }
}
