using System;

public class Place
{
    public string Name;
}

public class Program
{
    static void Main(string[] args)
    {
        var x = new Place() { x.Name = "北京" };
        Console.WriteLine(x.Name);
    }
}
