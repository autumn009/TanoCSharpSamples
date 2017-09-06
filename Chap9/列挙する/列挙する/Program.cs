using System;

internal enum MyColor
{
    Red = 1, Blue = 2, Yellow = 2
};

class Program
{
    static void Main(string[] args)
    {
        foreach (MyColor item in Enum.GetValues(typeof(MyColor)))
            Console.Write("{0},", item);
        Console.WriteLine();
        foreach (string item in Enum.GetNames(typeof(MyColor)))
            Console.Write("{0},", item);
        Console.WriteLine();
    }
}
