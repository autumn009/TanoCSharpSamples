using System;

class 動物
{
    public virtual void 鳴く()
    {
        Console.WriteLine("その動物は鳴いた");
    }
}

class 犬 : 動物
{
    public override void 鳴く()
    {
        Console.WriteLine("その犬はワンと鳴いた");
    }
}

class 猫 : 動物
{
    public override void 鳴く()
    {
        Console.WriteLine("その猫はニャーと鳴いた");
    }
}

class Program
{
    static void Main(string[] args)
    {
        動物 dog = new 犬();
        dog.鳴く();
    }
}
