using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        var a = new StringBuilder();
        a.Append("Hello!");
        a.Append("(追加しすぎた余計な文字)");
        Console.WriteLine(a);
        a.Length = 6;
        Console.WriteLine(a);
        a.Length = 4;
        Console.WriteLine(a);
    }
}
