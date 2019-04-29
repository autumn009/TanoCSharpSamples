using System;

public readonly struct Sample
{
    public readonly int x;
    public readonly void Write() => Console.WriteLine(x);
    public Sample(int x) => this.x = x;
}


class Program
{
    static void Main()
    {
        var a = new Sample(4649);
        a.Write();
    }
}
