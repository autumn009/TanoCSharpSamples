using System;
using System.Threading.Tasks;

public class Program
{
    private static async Task sample()
    {
        Console.WriteLine("start");
        await Task.Delay(1000);
        Console.WriteLine("end");
    }

    static void Main(string[] args)
    {
        sample();
    }
}
