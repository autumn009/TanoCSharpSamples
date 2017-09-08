using System;

public class Program
{
    public static void Main(string[] args)
    {
        string a = "Hello";
        Type t = a.GetType();
        Console.WriteLine(t.FullName);
    }
}
