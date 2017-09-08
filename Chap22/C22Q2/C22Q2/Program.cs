using System;

class Program
{
    static void Main(string[] args)
    {
        object a = "Andy" != "Betty" ? 1 : 1.5;
        Console.WriteLine(a.GetType().Name);
    }
}
