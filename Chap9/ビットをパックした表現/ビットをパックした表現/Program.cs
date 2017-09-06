using System;

class Program
{
    static void Main(string[] args)
    {
        const int 男性 = 1;
        const int 成人 = 2;
        var 太郎君 = 男性 | 成人;
        if ((太郎君 & 成人) != 0)
        {
            Console.WriteLine("太郎君は成人です");
        }
    }
}
