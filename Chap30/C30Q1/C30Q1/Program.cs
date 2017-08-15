using System;

#if false
class MyPoint
{
    public int X { get; }
    public int Y { get; }
    public MyPoint(int x, int y)
    {
        X = x;
        Y = y;
    }
}
#else
class MyPoint
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public MyPoint(int x, int y)
    {
        X = x;
        Y = y;
    }
}
#endif

class Program
{
    static void Main(string[] args)
    {
        var p = new MyPoint(123, 456);
        Console.WriteLine(p.X);
        Console.WriteLine(p.Y);
    }
}
