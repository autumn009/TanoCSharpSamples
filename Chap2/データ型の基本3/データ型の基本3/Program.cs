using System;

class Member
{
    internal string 名前;
    internal int 出席番号;
    internal void Write()
    {
        Console.WriteLine("名前{0},出席番号{1}", 名前, 出席番号);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Member a = new Member() { 名前 = "たろう", 出席番号 = 1 };
        Member b = new Member() { 名前 = "じろう", 出席番号 = 2 };
        Member c = new Member() { 名前 = "はなこ", 出席番号 = 4 };
        a.Write();
        b.Write();
        c.Write();
    }
}
