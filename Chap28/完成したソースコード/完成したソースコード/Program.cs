using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

class Program
{
    private static IEnumerable<string> GetData()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return i.ToString();
            Task.Delay(1000).Wait();
        }
    }
    static void Main(string[] args)
    {
        var start = DateTime.Now;
        Console.WriteLine(GetData().First());
        Console.WriteLine(DateTime.Now - start);
    }
}
