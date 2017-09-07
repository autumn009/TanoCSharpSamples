using System;

// 人クラスはインスタンス化されるのでstaticキーワードは付かない
class 人
{
    // 静的なメンバー
    public static int 拍手回数 { get; private set; }
    // インスタンスから呼び出すメソッド
    public void 拍手()
    {
        拍手回数++;
    }
    // 静的なコンストラクター
    static 人()
    {
        拍手回数 = 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 人クラスのインスタンスを2つ作る
        var たろう = new 人();
        var はなこ = new 人();
        // 拍手を3回
        たろう.拍手();
        はなこ.拍手();
        はなこ.拍手();
        // 静的なメンバーに残る拍手回数を出力
        Console.WriteLine(人.拍手回数);
    }
}
