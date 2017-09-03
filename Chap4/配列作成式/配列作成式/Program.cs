using System;

public class Program
{
    static void Main(string[] args)
    {
        var array = new int[4];
        array[0] = 0;
        array[1] = 2;
        array[2] = 4;
        array[3] = 6;
        foreach (var item in array) Console.Write(item);
    }
}
