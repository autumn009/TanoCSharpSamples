using System;

class Program
{
    static void Main(string[] args)
    {
        var x = 1;
        var y = 2;
        var a = string.Format("{0},{1}", x, y);
        var b = $"{x},{y}";
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
