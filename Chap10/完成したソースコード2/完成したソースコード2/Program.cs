using System;
using System.Linq;

interface 動物
{
    int 足の数();
}

interface 動物が鳴く
{
    void 鳴く();
}

abstract class 二足動物 : 動物
{
    public int 足の数()
    {
        return 2;
    }
}

abstract class 四足動物 : 動物
{
    public int 足の数()
    {
        return 4;
    }
}

class 人間 : 二足動物, 動物が鳴く
{
    public void 鳴く()
    {
        Console.WriteLine("びえーん");
    }
}

class 犬 : 四足動物, 動物が鳴く
{
    public void 鳴く()
    {
        Console.WriteLine("わん");
    }
}

class 猫 : 四足動物, 動物が鳴く
{
    public void 鳴く()
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
        foreach (var item in animals.Where(c => c.足の数() == 4).Cast<動物が鳴く>())
        {
            item.鳴く();
        }
    }
}
