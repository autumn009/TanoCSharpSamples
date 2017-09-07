using System;

class 個人情報
{
    public string 名前;
    public int 暗証番号;
    public bool 暗証番号設定済み;
}

class Program
{
    static void Main(string[] args)
    {
        個人情報[] array =
        {
            new 個人情報() { 名前 = "たろう", 暗証番号 = 4649, 暗証番号設定済み = true },
            new 個人情報() { 名前 = "はなこ" }
        };
        foreach (var item in array)
        {
            if (item.暗証番号設定済み)
                Console.WriteLine("{0}さんの暗証番号は{1}です。", item.名前, item.暗証番号);
            else
                Console.WriteLine("{0}さんの暗証番号は未設定です。", item.名前);
        }
    }
}
