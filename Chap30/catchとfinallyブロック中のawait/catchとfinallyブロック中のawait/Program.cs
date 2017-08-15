using System;
using System.Threading.Tasks;

namespace catchとfinallyブロック中のawait
{
    class Program
    {
        static async Task sub()
        {
            try
            {
                await Console.Out.WriteLineAsync("try");
            }
            finally
            {
                await Console.Out.WriteLineAsync("finally");
            }
        }

        static void Main(string[] args)
        {
            sub().Wait();
        }
    }
}
