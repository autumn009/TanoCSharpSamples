using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        // 同期オブジェクト
        object sync = new object();
        // キャンセルの通知オブジェクト
        var cts = new CancellationTokenSource();
        // タスクの開始
        var task = Task.Factory.StartNew(async (obj) =>
        {
            var token = (CancellationTokenSource)obj;
            for (; ; )
            {
                // 1000msつまり1秒待つ
                await Task.Delay(1000);
                lock (sync)
                {
                    // mm:ssは分と秒を2桁で出力する書式のリクエスト。他にもyyyyなら年を4桁などの指定がある
                    Console.WriteLine("{0:mm:ss}現在の処理済みデータ数は{1}です。", DateTime.Now, count);
                }
                // キャンセルが既にリクエストされている
                if (token.IsCancellationRequested) break;
            }
        }, cts);

        const int length = 25;
        for (int i = 0; i < length; i++)
        {
            /// 333msつまり0.333秒待つ
            Task.Delay(333).Wait();
            lock (sync)
            {
                count++;
            }
        }
        // スレッドちゃん、おわってね
        cts.Cancel();
        // 終わったよという返事を待つ
        task.Wait();
    }
}
