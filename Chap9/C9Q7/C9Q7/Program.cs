using System;

enum MyColor
{
    Red = 1,
    Green = 2,
    Blue = 3
}

class Program
{
    static void Main(string[] args)
    {
        MyColor c = MyColor.Blue;
        Console.WriteLine(c.HasFlag(MyColor.Red));
    }
}
