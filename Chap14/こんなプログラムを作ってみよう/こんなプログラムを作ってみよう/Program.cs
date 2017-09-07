using System;

class 人
{
    // ここに何が入る?
}

class Program
{
    static void Main(string[] args)
    {
        var たろう = new 人();
        var はなこ = new 人();
        たろう.拍手();
        はなこ.拍手();
        はなこ.拍手();
        Console.WriteLine(人.拍手回数);
    }
}
