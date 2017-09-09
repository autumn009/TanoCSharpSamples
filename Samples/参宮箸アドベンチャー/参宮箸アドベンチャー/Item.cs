using System;
using System.Runtime.Serialization;

namespace Sangubashi
{
    /// <summary>
    /// アイテムを扱うクラス
    /// </summary>
    public class Item
    {
        /// <summary>
        /// アイテムの名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// アイテム固有のuseコマンド
        /// </summary>
        public Action UseProc { get; set; }
        /// <summary>
        /// 特に指定しなかった時の挙動
        /// </summary>
        public virtual void Use()
        {
            if (UseProc != null) UseProc();
            else Console.WriteLine("しかし、何も起こらなかった。");
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">名前</param>
        public Item(string name)
        {
            Name = name;
        }
    }
    /// <summary>
    /// 着衣アイテム
    /// </summary>
    public class Wareitem : Item
    {
        /// <summary>
        /// 使用した時の挙動
        /// </summary>
        public override void Use()
        {
            if (State.OnlyOne.Wearingitem.Name == Name)
                Console.WriteLine("僕は既に{0}を着ている。", Name);
            else
            {
                Console.Write("僕は{0}を脱いで、", State.OnlyOne.Wearingitem.Name);
                State.OnlyOne.WearingitemName = this.Name;
                Console.WriteLine("{0}に着替えた。", Name);
            }
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">名前</param>
        public Wareitem(string name) : base(name) { }
    }
}
