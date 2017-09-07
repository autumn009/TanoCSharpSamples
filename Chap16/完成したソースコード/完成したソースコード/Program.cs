using System;
using System.Linq;

struct Point
{
    public int X;
    public int Y;
}

class Program
{
    static void Main(string[] args)
    {
        DateTime start = DateTime.Now;
        Point[] points = new Point[100000000];
        Console.WriteLine(DateTime.Now - start);
        Console.WriteLine("points.Last().X={0}", points.Last().X);
        Console.WriteLine("points.Last().Y={0}", points.Last().Y);
    }
}
