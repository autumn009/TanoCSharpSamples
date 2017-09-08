using System;
using System.Threading.Tasks;

public class Program
{
    private static async Task<TimeSpan> sample()
    {
        var start = DateTime.Now;
        await Task.Delay(1000);
        return DateTime.Now - start;
    }

    static void Main(string[] args)
    {
        var span = sample();
        Console.WriteLine("経過時間:{0}", span.Result);
    }
}
