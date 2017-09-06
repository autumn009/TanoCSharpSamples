using System;

internal enum MyColor : byte
{
    Red = 1, Blue = 2, Yellow = 3
};
//internal enum MyColor : byte
//{
//    Red = 100, Blue = 200, Yellow = 300
//};

class Program
{
    static void Main(string[] args)
    {
        var col = MyColor.Blue;
        Console.WriteLine(col);
    }
}
