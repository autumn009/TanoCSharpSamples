using System;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        var o = new object();
        var t = new Task(() =>
        {
            lock (o)
            {
                Console.WriteLine("task start");
                var d = Task.Delay(1000);
                d.Wait();
                Console.WriteLine("task done");
            }
        });
        t.Start();
        var d2 = Task.Delay(100);
        d2.Wait();
        lock (o)
        {
        }
        Console.WriteLine("main done");
    }
}
