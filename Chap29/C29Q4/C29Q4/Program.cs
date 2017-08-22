using System;

public class Program
{
    private static int x;
    private static void sample()
    {
        Console.WriteLine(x);
    }
    static void Main(string[] args)
    {
        x = 123;
        Action f = new Action(sample);
        x = 456;
        f();
        x = 789;
    }
}
