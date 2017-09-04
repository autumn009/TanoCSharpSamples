using System;

public class Program
{
    public static void Main(string[] args)
    {
        string s = "I am Joe";
        {
            s = "I am Jane";
            Console.WriteLine(s);
        }
        Console.WriteLine(s);
    }
}
