using System;
using System.Threading.Tasks;

class Program
{
    private static async void waitOneSec()
    {
        await Task.Delay(1000);
    }

    static void Main(string[] args)
    {
        waitOneSec();
    }
}
