using System;

class たろう作便利クラス
{
    public readonly string Name;
    public void SayName()
    {
        Console.WriteLine("大きな文字でオレの名前を言ってみろ。はい「{0}」", Name.ToUpper());
    }
    // 引数を持つコンストラクタ
    public たろう作便利クラス(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // コンストラクタの引数に値を書かねばコンパイルエラーになる
        var obj = new たろう作便利クラス("Michel");
        obj.SayName();
    }
}
