using System;

delegate void Sample();

public class Program
{

    private static void sample()
    {
        Console.WriteLine("in sample");
    }

    static void Main(string[] args)
    {
        Sample f = new Sample(sample);
        f();
    }
}
