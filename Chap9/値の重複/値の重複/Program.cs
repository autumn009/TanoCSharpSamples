using System;

internal enum MyColor
{
    Red = 1, Blue = 1, Yellow = 1
};

class Program
{
    static void Main(string[] args)
    {
        var col = MyColor.Yellow;
        Console.WriteLine(col);
    }
}
