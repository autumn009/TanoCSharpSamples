using System;

struct 出席番号
{
    public int 番号;
}

class 生徒名
{
    public string 名前;
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
            if (/* ここにどんな式を書けば良いだろうか */.番号 == i)
            {
                Console.WriteLine("出席番号{0}はいません。", i);
            }
        }
    }
}

