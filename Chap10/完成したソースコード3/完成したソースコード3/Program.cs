using System;
using System.Linq;

abstract class 動物
{
    public abstract void 鳴く();
}

abstract class 二足動物 : 動物 { }

abstract class 四足動物 : 動物 { }

class 人間 : 二足動物
{
    public override void 鳴く()
    {
        Console.WriteLine("びえーん");
    }
}

class 犬 : 四足動物
{
    public override void 鳴く()
    {
        Console.WriteLine("わん");
    }
}

class 猫 : 四足動物
{
    public override void 鳴く()
    {
        Console.WriteLine("にゃん");
    }
}

class Program
{
    static void Main(string[] args)
    {
        動物[] animals =
        {
            new 人間(),
            new 犬(),
            new 猫()
        };
        foreach (var item in animals.OfType<四足動物>())
        {
            item.鳴く();
        }
    }
}
