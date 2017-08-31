using System;
using System.Linq;

class X
{
    public string Name;
}

public class Program
{
    static void Main(string[] args)
    {
        string[] names = { "alice", "BETTY", "Cindy" };
        var upperNames = names.Select(c => new X() { Name = c.ToUpper() });
        foreach (var item in upperNames) Console.WriteLine(item.Name);
    }
}
