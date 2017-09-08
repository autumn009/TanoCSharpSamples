using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();
        Parallel.Invoke(async () =>
        {
            await Task.Delay(random.Next(1000));
            Console.WriteLine("One");
        },
        async () =>
        {
            await Task.Delay(random.Next(1000));
            Console.WriteLine("Two");
        },
        async () =>
        {
            await Task.Delay(random.Next(1000));
            Console.WriteLine("Three");
        });
        Task.Delay(random.Next(2000)).Wait();
    }
}
