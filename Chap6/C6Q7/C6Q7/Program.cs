using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        var a = new StringBuilder();
        a.Append("Hello!");
        a.Length = 4;
        a.Append("Hello!");
        a.Length = 6;
        Console.WriteLine(a);
    }
}
