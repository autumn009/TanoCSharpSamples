using System;
using System.Linq;
using System.Reflection;

class Place
{
    public readonly string Name;
    public Place(string name)
    {
        Name = name;
    }
}

class 駅Place : Place
{
    public 駅Place() : base("駅") { }
}

class 自宅Place : Place
{
    public 自宅Place() : base("自宅") { }
}

class 学校Place : Place
{
    public 学校Place() : base("学校") { }
}

class Program
{
    static void Main(string[] args)
    {
        // 実行中のアセンブリ(DLL)の情報を得る
        Place[] places = Assembly.GetExecutingAssembly()
            // 全ての型を得る
            .GetTypes()
            // Placeクラスを継承しているクラスだけ選ぶ
            .Where(c => c.IsSubclassOf(typeof(Place)))
            // Activator.CreateInstanceメソッドは型情報からオブジェクトを作る
            .Select(c => (Place)Activator.CreateInstance(c))
            // 配列化する
            .ToArray();
        foreach (var item in places)
        {
            Console.WriteLine(item.Name);
        }
    }
}
