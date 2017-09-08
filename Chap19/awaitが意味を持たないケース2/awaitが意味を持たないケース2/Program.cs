using System;
using System.Threading.Tasks;

public class Program
{
    private static void sample()
    {
        Console.WriteLine("start");
        var task = Task.Delay(1000);
        task.Wait();
        Console.WriteLine("end");
    }

    static void Main(string[] args)
    {
        sample();
    }
}
