using System;

class ProgressEventArgs : EventArgs
{
    public int rate { get; set; }
}

delegate void ProgressEventHandler(Object sender, ProgressEventArgs e);

class X
{
    public event EventHandler OnNotifyStart;
    public event EventHandler OnNotifyEnd;
    public event ProgressEventHandler OnNotifyProgress;
    public int 計算()
    {
        int sum = 0;
        OnNotifyStart(this, new EventArgs());
        for (int i = 0; i < 10; i++)
        {
            OnNotifyProgress(this, new ProgressEventArgs() { rate = i * 10 });
            sum += i;
        }
        OnNotifyEnd(this, new EventArgs());
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new X();
        a.OnNotifyStart += (sender, e) =>
        {
            Console.WriteLine("計算開始");
        };
        a.OnNotifyProgress += (sender, e) =>
        {
            Console.WriteLine("計算進捗{0}%", e.rate);
        };
        a.OnNotifyEnd += (sender, e) =>
        {
            Console.WriteLine("計算終了");
        };
        Console.WriteLine("計算結果{0}", a.計算());
    }
}
