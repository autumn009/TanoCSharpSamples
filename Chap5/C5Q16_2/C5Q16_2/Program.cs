using System;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        Thread.Sleep(1000);
        Console.WriteLine(DateTime.Now.ToLongTimeString());
    }
}
