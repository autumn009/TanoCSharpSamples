using System;

class Y
{
    public void MethodY(X x)
    {
        /* ここに何を書けば良いだろうか? */
        Console.WriteLine("あなたに愛を込めて。");
    }
}

class X
{
    public void MethodX()
    {
        Y y = new Y();
        y.MethodY(this);
    }
}

class X2 : X
{
    public void SpecialFunction()
    {
        Console.WriteLine("特別なあなたに愛を込めて。");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var x1 = new X();
        var x2 = new X2();
        x1.MethodX();
        x2.MethodX();
    }
}
