using System;

public class Program
{
    static void Main(string[] args)
    {
        var array = new int[10];
        for (int i = 0; i < array.Length; i++) array[i] = i * 2;
        foreach (var item in array) Console.Write(item);
    }
}
