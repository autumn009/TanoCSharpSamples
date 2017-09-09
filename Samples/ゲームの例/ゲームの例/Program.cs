using System;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();
        Console.WriteLine("1から10までの数を当てて下さい。");
        var val = int.Parse(Console.ReadLine());
        int target;

        for (; ; )
        {
            target = random.Next(9) + 1;
            if (target != val) break;
        }

        for (; ; )
        {
            if (target > val)
                Console.WriteLine("小さすぎます");
            else if (target < val)
                Console.WriteLine("大ぎます");
            else
                break;

            Console.WriteLine("1から10までの数を当てて下さい。");
            val = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("当たりです。");
    }
}
