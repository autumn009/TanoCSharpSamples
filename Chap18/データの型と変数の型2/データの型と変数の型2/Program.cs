using System;

public class Program
{
    public static void Main(string[] args)
    {
        object x = DateTime.Now;
        Console.WriteLine(x.GetType().Name);
    }
}
