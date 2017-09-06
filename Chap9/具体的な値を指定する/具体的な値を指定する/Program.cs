using System;

internal enum MyColor
{
    Red = 123, Blue = 456, Yellow = 789
};

class Program
{
    static void Main(string[] args)
    {
        var col = MyColor.Blue;
        Console.WriteLine((int)col);
    }
}
