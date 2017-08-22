using System;

class Program
{
    private static T Sample<T>()
    {
        return default(T);
    }

    static void Main(string[] args)
    {
        int a = Sample<int>();
        Console.WriteLine(a);
    }
}
