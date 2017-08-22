using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

class Program
{
    private static string[] GetData()
    {
        var list = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(i.ToString());
            Task.Delay(1000).Wait();
        }
        return list.ToArray();
    }
    static void Main(string[] args)
    {
        var start = DateTime.Now;
        Console.WriteLine(GetData().First());
        Console.WriteLine(DateTime.Now - start);
    }
}
