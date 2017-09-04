using System;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        var now = DateTime.Now.ToLongTimeString();
        Thread.Sleep(1000);
        Console.WriteLine(now);
    }
}
