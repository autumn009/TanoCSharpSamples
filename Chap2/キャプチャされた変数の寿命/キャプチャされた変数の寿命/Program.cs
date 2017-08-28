using System;

class Program
{
    private static Action sample()
    {
        var msg = "Hello Sample";
        return () =>
        {
            Console.WriteLine(msg);
        };
    }

    static void Main(string[] args)
    {
        var result = sample();
        result();
    }
}
