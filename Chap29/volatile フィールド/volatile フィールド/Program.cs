using System;
using System.Threading.Tasks;

class Program
{
    private static volatile bool flag = false;
    static void Main(string[] args)
    {
        Task.Run(() =>
        {
            Console.WriteLine("stop to wait");
            flag = true;
        });
        Console.WriteLine("start to wait");
        while (flag == false) ;
        Console.WriteLine("done");
    }
}
