using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var task = Task.Factory.StartNew(async () =>
        {
            await Task.Delay(1000);
            Console.Write("Hello!");
        });
    }
}
