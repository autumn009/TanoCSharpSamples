using System;

ref struct Sample
{
    public void Dispose()
    {
        Console.WriteLine("Disposed");
    }
}

class Program
{
    static void Main()
    {
        using(var s = new Sample())
        {
            Console.WriteLine("Now working 'ref struct Sample!'");
        }
    }
}
