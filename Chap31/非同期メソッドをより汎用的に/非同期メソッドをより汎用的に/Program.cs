using System;
using System.Threading.Tasks;

class Program
{
    private static async ValueTask<int> sub()
    {
        await Task.Delay(0);
        return 1;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(sub().Result);
    }
}

