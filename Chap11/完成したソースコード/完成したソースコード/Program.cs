using System;

class たろう君
{
    public void SayMyName()
    {
        Console.WriteLine("僕はたろうだ。");
    }
    private int _テストの得点;
    public int テストの得点
    {
        get
        {
            return _テストの得点;
        }
        set
        {
            if (value < 0 || value > 100) throw new ArgumentOutOfRangeException("value", "得点の範囲は0から100までです。");
            _テストの得点 = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var t = new たろう君();
            t.テストの得点 = 101;
            t.SayMyName();
            Console.WriteLine("テストは{0}点だ。", t.テストの得点);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("実行中に例外が発生しました。");
            Console.WriteLine(e.Message);
        }
    }
}
