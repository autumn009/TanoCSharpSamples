using System;

class Program
{
    private static T sample<T>()
    {
        return default(T);
    }

    static void Main(string[] args)
    {
        var t = sample<int>();
        Console.WriteLine(t);
    }
}
