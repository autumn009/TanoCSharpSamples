using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        var a = new StringBuilder();
        a.Append("Hello!");
        //a = a.ToUpper();    // NG
        string s = a.ToString();
        s = s.ToUpper();    // OK
        Console.WriteLine(s);
    }
}
