using System;

class Math
{
    public void Hello()
    {
        Console.WriteLine("I'm Math!");
    }
}

class Program
{
    static void Main()
    {
        var math = new Math();
        math.Hello();
    }
}
