using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        await Console.Out.WriteLineAsync("Async Hello World!");
    }
}
