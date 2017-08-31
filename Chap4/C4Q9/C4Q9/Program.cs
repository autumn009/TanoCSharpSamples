using System;

public class Program
{
    static void Main(string[] args)
    {
        var array = new object[10];
        foreach (var item in array) Console.Write(item.ToString());
    }
}
