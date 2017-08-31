using System;

public class Program
{
    static void Main(string[] args)
    {
        var a = new { x = 1, y = 2 };
        Console.WriteLine("x={0}", a.x);
        Console.WriteLine("y={0}", a.y);
    }
}
