using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        string[] names = { "alice", "BETTY", "Cindy" };
        var upperNames = names.Select(c => c.ToUpper());
        foreach (var item in upperNames) Console.WriteLine(item);
    }
}
