using System;
using System.Text;  // StringBuilderを短く書くため

class Program
{
    // これが主テーマのメソッドだ
    private static string sample(string s)
    {
        // 結果を蓄積するオブジェクトを準備する
        var sb = new StringBuilder();
        // 最初のモードは変換オン
        bool sw = true;
        // 文字列を文字単位で列挙する
        foreach (var item in s)
        {
            // ダブルクオートならスイッチを切り替え
            if (item == '"') sw = !sw;
            // スイッチオンかつ$ならマクロを置き換え
            if (sw && item == '$') sb.Append("たろう");
            else sb.Append(item);
        }
        // 文字列に置き換えて出力
        return sb.ToString();
    }

    static void Main(string[] args)
    {
        var s = @"僕の名前は$です。""このペンは$10で買いました""";
        Console.WriteLine(sample(s));
    }
}
