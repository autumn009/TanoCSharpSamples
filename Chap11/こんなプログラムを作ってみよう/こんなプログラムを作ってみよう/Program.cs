using System;

class たろう君
{
    public void SayMyName()
    {
        Console.WriteLine("僕はたろうだ。");
    }
    public int テストの得点;
}

class Program
{
    static void Main(string[] args)
    {
        var t = new たろう君();
        t.テストの得点 = 100;
        t.SayMyName();
        Console.WriteLine("テストは{0}点だ。", t.テストの得点);
    }
}
