using System;

public class Place
{
    public string Name;
}

public class Program
{
    static void Main(string[] args)
    {
        var x = new Place();
        x.Name = "東京";
        var y = new Place();
        y.Name = "大阪";
        Console.WriteLine(x.Name);
        Console.WriteLine(y.Name);
    }
}
