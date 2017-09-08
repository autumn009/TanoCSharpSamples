using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var cts = new CancellationTokenSource();
        var task = Task.Factory.StartNew(async (obj) =>
        {
            var token = (CancellationTokenSource)obj;
            for (int i = 0; ; i++)
            {
                Console.Write(i);
                await Task.Delay(1000);
                if (token.IsCancellationRequested) break;
            }
        }, cts);
        Task.Delay(10000).Wait();
        cts.Cancel();
        task.Wait();
    }
}
