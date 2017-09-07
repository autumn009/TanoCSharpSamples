using System;

class たろう作便利クラス
{
    public string Name;
    public void SayName()
    {
        Console.WriteLine("大きな文字でオレの名前を言ってみろ。はい「{0}」", Name.ToUpper());
    }
}

class Program
{
    static void Main(string[] args)
    {
        var obj = new たろう作便利クラス();
        obj.Name = "Michel"; // ←みんなが書き忘れるフィールドの初期化
        obj.SayName();
    }
}

