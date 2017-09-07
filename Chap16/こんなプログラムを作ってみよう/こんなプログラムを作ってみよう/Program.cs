using System;
using System.Linq;

class Point
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
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = new Point();
        }
        Console.WriteLine(DateTime.Now - start);
        Console.WriteLine("points.Last().X={0}", points.Last().X);
        Console.WriteLine("points.Last().Y={0}", points.Last().Y);
    }
}
