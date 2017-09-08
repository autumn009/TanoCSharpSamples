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
        Console.Write("A");
        a.OnNotify += (sender, e) =>
        {
            Console.Write("B");
        };
        Console.Write("C");
        a.OnNotify += (sender, e) =>
        {
            Console.Write("D");
        };
        Console.Write("E");
        a.A();
        Console.Write("F");
    }
}
