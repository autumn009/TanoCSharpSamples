using System;

record struct Sample(int x,int y);

class Program
{
    static void Main()
    {
        Sample a = new Sample(123,456);
        Console.WriteLine($"x={a.x} y={a.y} IsValueType={a.GetType().IsValueType}");
    }
}
