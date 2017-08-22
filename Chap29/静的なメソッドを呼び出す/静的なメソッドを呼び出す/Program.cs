using System;

public class A
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(A.Add(2, 3));
    }
}
