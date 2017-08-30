using System;       // この行があるおかげで、Console.WriteLineの手前にSystem.と書く必要が無くなる
using System.Linq;  // LINQを使用するスイッチを入れる

// メソッドの入れものになるクラスだ
// この場合、Mainメソッドの入れものとしての役割しか
// 要求されていないので、名前は何でも良い
class Program
{
    // 最初に実行されるMainメソッドだ
    static void Main()
    {
        // 要素を5個持つ配列変数を宣言している
        int[] weights = { 7, 12, 5, 9, 17 };
        // LINQのWhereメソッドで、条件に合致するデータだけを集めた塊を作り、変数に入れている
        // Whereメソッドの引数はラムダ式で、ラムダ式の中身は10kg以上を示す条件式だ
        var weightsOver10kg = weights.Where(c => c >= 10);
        // MinメソッドはLINQのメソッドで最小値を計算する。
        // 変数weightsOver10kgに対して使っているので、10kg以上の最小値
        Console.WriteLine("最軽量の石の重さは{0}kgです。", weightsOver10kg.Min());
        // MaxメソッドはLINQのメソッドで最大値を計算する。
        Console.WriteLine("最重量の石の重さは{0}kgです。", weightsOver10kg.Max());
        // AverageメソッドはLINQのメソッドで平均値を計算する。
        Console.WriteLine("平均の石の重さは{0}kgです。", weightsOver10kg.Average());
        // if文が成立したときだけ後続の文は実行される
        // if文の条件式は、Anyメソッド。
        // AnyメソッドはLINQのメソッドで、条件に合致するデータが1つでもあればtrueになる(条件が成立する)
        // Anyメソッドの引数はラムダ式で、値が12の場合に条件が成立する
        if (weights.Any(c => c == 12)) Console.WriteLine("重さ12kgの石は含まれます。");
    }
}
