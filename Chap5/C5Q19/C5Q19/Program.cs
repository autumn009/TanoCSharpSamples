using System;

class Program
{
    static void Main(string[] args)
    {
        string s = "XYZ";
        int a;
        int.TryParse(s, out a);
        Console.WriteLine(a);
    }
}
