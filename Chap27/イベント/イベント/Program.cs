using System;

class X
{
    public event EventHandler OnNotify;
    public void A()
    {
        // イベント発生
        OnNotify(this, new EventArgs());
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new X();
        a.OnNotify += (sender, e) =>
        {
            Console.WriteLine("オブジェクトaでイベント発生!");
        };
        a.A();
    }
}
