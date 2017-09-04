using System;
using System.Collections.Generic;   // List<T>クラスを短く書くため
using System.Linq;  // Avarageクラスを使うため

class Program
{
    // データを1つ読み取る
    private static int read()
    {
        // 数値を受け取るまで繰り返す
        for (; ; )
        {
            // 1行を利用者から受け取る
            string s = Console.ReadLine();
            // コンソール入力がリダイレクトされたときにファイルの終わりに達したとき
            // 0=終わりのマークが入力されたものとする
            if (s == null) return 0;
            // TryParseメソッドの結果受け取り用変数
            int r;
            // TryParseメソッドで文字列を整数に変換する
            // 成功したらメソッドを終える
            if (int.TryParse(s, out r)) return r;
            // 再入力リクエストを出力する
            Console.WriteLine("数値として解釈できません。再入力してください。");
        }
    }

    static void Main(string[] args)
    {
        // 結果を受け取るリストを作成する
        var list = new List<int>();
        // 無限ループ開始
        for (; ; )
        {
            // 数値を1つ受け取る
            int r = read();
            // 0なら繰り返すから脱出
            if (r == 0) break;
            // リストに入力された値を追加する
            list.Add(r);
        }
        // 平均値を出力する
        Console.WriteLine(list.Average());
    }
}
