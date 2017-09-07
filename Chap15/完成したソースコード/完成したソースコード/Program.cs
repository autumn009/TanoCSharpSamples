using System;

class Y
{
    public void MethodY(X x)
    {
        X2 x2 = x as X2;
        if (x2 != null) x2.SpecialFunction();
        else Console.WriteLine("あなたに愛を込めて。");
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
