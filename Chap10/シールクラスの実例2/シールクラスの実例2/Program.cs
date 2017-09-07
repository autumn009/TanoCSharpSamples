using System;

class MyRandom : Random
{
    public override int Next()
    {
        return 100;
    }
}

class Program
{
    private static void output(Random r)
    {
        Console.WriteLine(r.Next());
        Console.WriteLine(r.Next());
    }

    static void Main(string[] args)
    {
        var r1 = new Random();
        output(r1);
        var r2 = new MyRandom();
        output(r2);
    }
}
