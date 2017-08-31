using System;
using System.Linq;

// 装備相手の情報を持つクラス
class Item
{
    // 装備アイテムの名前
    public string Name;
    // 装備アイテムの防御力
    public int Defence;
}

// パーティーの構成メンバーの情報を持つクラス
class Person
{
    // メンバーの名前
    public string Name;
    // メンバーの防御力
    public int Defence;
    // メンバーの装備防具
    public Item Equip;
}

// Mainメソッドを用意するためのクラス
class Program
{
    // 実行されるメソッド本体
    static void Main()
    {
        // 防具アイテムを準備する
        var aegisShield = new Item() { Name = "イージスの盾", Defence = 10 };
        var woodShield = new Item() { Name = "木の盾", Defence = 3 };
        var mageRobe = new Item() { Name = "魔法使いのローブ", Defence = 1 };
        // モンスターに立ち向かうパーティーを配列として用意する
        Person[] party =
        {
            new Person(){ Name="勇者ライデン", Defence=10, Equip = aegisShield },
            new Person(){ Name="カブキ者団十郎", Defence=5, Equip = woodShield },
            new Person(){ Name="魔法使いサリーマン", Defence=2, Equip = mageRobe },
        };
        // モンスターの攻撃力と攻撃力の表明
        int attack = 20;
        Console.WriteLine("モンスターの全体攻撃。モンスターは全てのメンバーに{0}の力で攻撃した。", attack);
        // ダメージ計算を行う式を記述する (計算式を定義するだけでここでは計算しない)
        var q = party.Select(c => new { character = c, damage = attack - (c.Defence + c.Equip.Defence) / 2 });
        // 計算を行い、結果を出力する
        foreach (var item in q)
        {
            Console.WriteLine("{0}を装備した{1}は、{2}ダメージを受けた。", item.character.Equip.Name, item.character.Name, item.damage);
        }
    }
}
