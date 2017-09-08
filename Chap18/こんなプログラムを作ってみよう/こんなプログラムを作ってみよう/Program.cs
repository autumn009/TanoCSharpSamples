using System;

class Place
{
    public readonly string Name;
    public Place(string name)
    {
        Name = name;
    }
}

class 駅Place : Place
{
    public 駅Place() : base("駅") { }
}

class 自宅Place : Place
{
    public 自宅Place() : base("自宅") { }
}

class 学校Place : Place
{
    public 学校Place() : base("学校") { }
}

class Program
{
    static void Main(string[] args)
    {
        Place[] places = /* ここをどう書くか */
        //Place[] places =
        //{
        //    new 駅Place(),
        //    new 自宅Place(),
        //    new 学校Place()
        //};
        foreach (var item in places)
        {
            Console.WriteLine(item.Name);
        }
    }
}

 
