using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();
        Parallel.For(0, 10, (i) =>
        {
            Task.Delay(random.Next(2000)).Wait();
            Console.Write(i);
        });
    }
}
