using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        const int length = 10;
        var task = Task.Factory.StartNew(() =>
        {
            for (int i = 0; i < length; i++)
            {
                Task.Delay(100).Wait();
                Console.Write("A");
            }
        });
        for (int i = 0; i < length; i++)
        {
            Task.Delay(60).Wait();
            Console.Write("B");
        }
        task.Wait();
    }
}
