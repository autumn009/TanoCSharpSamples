using System;

public class Program
{
    private static void sample(object a)
    {
        Console.WriteLine(a);
    }

    static void Main(string[] args)
    {
        sample(1);
        sample("2");
        sample(new Program());
    }
}
