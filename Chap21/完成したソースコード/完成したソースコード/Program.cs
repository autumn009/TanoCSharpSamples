using System;
using System.Linq;

struct 出席番号
{
    public int 番号;
}

class 生徒名
{
    public string 名前;
    public static implicit operator 出席番号(生徒名 a)
    {
        int number = 0;
        if (a.名前 == "たろう") number = 1;
        if (a.名前 == "じろう") number = 2;
        if (a.名前 == "さぶろう") number = 3;
        return new 出席番号() { 番号 = number };
    }
}

class Program
{
    static void Main(string[] args)
    {
        object[] array =
        {
            new 生徒名() {  名前="たろう"},
            new 出席番号() { 番号=2 },
            new 生徒名() {  名前="さぶろう"},
        };

        for (int i = 1; i < 5; i++)
        {
            if (!array.Any(c => (c is 出席番号 ? (出席番号)c : (生徒名)c).番号 == i))
            {
                Console.WriteLine("出席番号{0}はいません。", i);
            }
        }
    }
}
