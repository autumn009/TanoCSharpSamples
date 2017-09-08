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

    static async Task Main(string[] args)
    {
        var span = await sample();
        Console.WriteLine("経過時間:{0}", span);
    }
}
