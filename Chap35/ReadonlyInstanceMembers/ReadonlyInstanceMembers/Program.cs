using System;

public struct Sample
{
    public int X { get; set; }
    readonly public void SubOK()
    {
        Console.WriteLine(X+1);
    }
    //readonly public void SubFail()
    //{
    //  X++;
    //  Console.WriteLine(X);
    //}
}

class Program
{
    static void Main()
    {
        var a = new Sample();
        a.X = 1;
        a.SubOK();
    }
}
