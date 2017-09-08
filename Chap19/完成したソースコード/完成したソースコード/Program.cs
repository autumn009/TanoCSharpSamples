using System;
using System.Threading.Tasks;

class Program
{
    // 戻り値の型をTaskに変更している。Waitメソッドで待ちたいからである
    private static async Task waitOneSec()
    {
        await Task.Delay(1000);
    }

    static void Main(string[] args)
    {
        // Task.Waitメソッドはタスクの終了を待つ
        waitOneSec().Wait();
    }
}
