using System;
using System.Reflection;

class A
{
    public static int X = 123;
}

class Program
{
    static void Main(string[] args)
    {
        //int val = (int)(typeof(A).GetField(nameof(A.X)).GetValue(null));
        int val = (int)(typeof(A).GetField("X").GetValue(null));
        Console.WriteLine(val);
    }
}
