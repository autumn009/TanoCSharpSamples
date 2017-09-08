using System;

class 個人情報
{
    public string 名前;
    public int? 暗証番号;
}

class Program
{
    static void Main(string[] args)
    {
        個人情報[] array =
        {
            new 個人情報() { 名前 = "たろう", 暗証番号 = 4649 },
            new 個人情報() { 名前 = "はなこ", 暗証番号 = null }
        };
        foreach (var item in array)
        {
            // ここでnull合体演算子は使用できないことに注意しよう
            if (item.暗証番号 != null)
                Console.WriteLine("{0}さんの暗証番号は{1}です。", item.名前, item.暗証番号);
            else
                Console.WriteLine("{0}さんの暗証番号は未設定です。", item.名前);
        }
    }
}
