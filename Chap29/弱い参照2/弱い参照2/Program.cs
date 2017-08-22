using System;

class Program
{
    static void Main(string[] args)
    {
        var ar = new WeakReference("Hello!");
        if (ar.IsAlive)
        {
            Console.WriteLine("メモリは生きています。内容は{0}です。", ar.Target);
        }
        else
        {
            Console.WriteLine("メモリは破棄されました。");
        }
    }
}
