using System;
using System.Runtime.Serialization;

namespace Sangubashi
{
    /// <summary>
    /// 全ての場所の既定抽象クラス
    /// </summary>
    public abstract class Place
    {
        /// <summary>
        /// 場所のID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 場所の名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// lookコマンド使用時のリアクション
        /// </summary>
        public Action LookProc { get; set; }
        /// <summary>
        /// lookコマンドの処理 LookProcがあればそれを呼ぶ
        /// </summary>
        public void Look()
        {
            if (LookProc == null)
                Console.WriteLine("特に何も無かった。");
            else LookProc();
        }
        /// <summary>
        /// コマンドのアクション
        /// </summary>
        /// <param name="command">コマンド</param>
        /// <returns>trueを返すとゲーム終了</returns>
        public virtual bool CommandAction(CommandInfo command)
        {
            if (command.Verb == "use") Util.UseCommand(command);
            else if (command.Verb == "go") Util.GoCommand(command);
            else if (command.Verb == "look") Util.LookCommand(command);
            else if (command.Verb == "enter") Util.EnterCommand(command);
            else if (command.Verb == "exit") Util.ExitCommand(command);
            else if (command.Verb == "sing") State.OnlyOne.CurrentPlace.SingCommand(command);
            else if (command.Verb == "inventory") Util.InventoryCommand(command);
            else if (command.Verb == "repartory") Util.RepatoryCommand(command);
            else if (command.Verb == "load") Util.LoadCommand(command);
            else if (command.Verb == "save") Util.SaveCommand(command);
            else Util.Hints();
            return false;
        }
        /// <summary>
        /// singコマンドの処理の実体
        /// </summary>
        /// <param name="command">コマンド</param>
        public virtual void SingCommand(CommandInfo command)
        {
            if (command.Object == "")
            {
                Console.WriteLine("しかし、何を歌ってよいか分からなかった。");
                return;
            }
            if (!State.OnlyOne.Songs.Contains(command.Object))
            {
                Console.WriteLine("しかし、{0}は歌えなかった。", command.Object);
                return;
            }
            Console.WriteLine("僕は{0}を熱唱した。", command.Object);
            return;
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">場所の名前</param>
        /// <param name="id">識別ID</param>
        public Place(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
    /// <summary>
    /// 東西南北の方向を持つ場所
    /// </summary>
    public class GlobalPlace : Place
    {
        /// <summary>
        /// 西に行くときの場所
        /// </summary>
        public Func<GlobalPlace> WestPlace { get; set; }
        /// <summary>
        /// 東に行くときの場所
        /// </summary>
        public Func<GlobalPlace> EastPlace { get; set; }
        /// <summary>
        /// 北に行くときの場所
        /// </summary>
        public Func<GlobalPlace> NorthPlace { get; set; }
        /// <summary>
        /// 南に行くときの場所
        /// </summary>
        public Func<GlobalPlace> SouthPlace { get; set; }
        /// <summary>
        /// その場所の店に行くときの行き先
        /// </summary>
        public Func<SubPlace> SubPlace { get; set; }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">場所の名前</param>
        /// <param name="id">識別ID</param>
        public GlobalPlace(string name, string id) : base(name, id) { }
    }
    /// <summary>
    /// グローバルの場所に従属する場所。東西南北には移動できない
    /// </summary>
    public class SubPlace : Place
    {
        /// <summary>
        /// 出るときのexitコマンドの行き先場所
        /// </summary>
        public Func<GlobalPlace> ExitPlace { get; set; }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">場所の名前</param>
        public SubPlace(string name) : base(name, name) { }
    }
    /// <summary>
    /// 拳闘博物館
    /// </summary>
    public class 拳闘博物館Place : GlobalPlace
    {
        /// <summary>
        /// コマンドのアクション
        /// </summary>
        /// <param name="command">コマンド</param>
        /// <returns>trueを返すとゲーム終了</returns>
        public override bool CommandAction(CommandInfo command)
        {
            if (command.Verb == "sing"
                && command.Object == Constants.夏の小川
                && State.OnlyOne.Songs.Contains(Constants.夏の小川)
                && State.OnlyOne.Wearingitem.Name == Util.旧型のスクール水着.Name
)
            {
                Console.WriteLine("僕は旧型のスクール水着で{0}を熱唱した。", Constants.夏の小川);
                Console.WriteLine("「野暮ったい昔の水着で{0}とは懐かしいじゃないか」と知らないおじさんが出てきた。", Constants.夏の小川);
                Console.WriteLine("彼はこの博物館の館長だと名乗った。");
                Console.WriteLine("「この博物館がある敷地こそ、あの有名な{0}の水源地だったのだよ」", Constants.夏の小川);
                Console.WriteLine("「夏にはクラスの女の子達が野暮ったい水着でいつも遊んでいたよ」");
                Console.WriteLine("{0}の源流地は拳闘博物館だったのだ。ミッション完了だ。", Constants.夏の小川);
                return true;
            }
            return base.CommandAction(command);
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public 拳闘博物館Place() : base("拳闘博物館", "拳闘博物館") { }
    }
    /// <summary>
    /// 元ア好き編集部
    /// </summary>
    public class 元ア好き編集部Place : GlobalPlace
    {
        /// <summary>
        /// コマンドのアクション
        /// </summary>
        /// <param name="command">コマンド</param>
        /// <returns>trueを返すとゲーム終了</returns>
        public override bool CommandAction(CommandInfo command)
        {
            if (command.Verb == "sing"
                && command.Object == Constants.ヤマモト
                && State.OnlyOne.Songs.Contains(Constants.ヤマモト)
)
            {
                Console.WriteLine("僕は{0}を熱唱した。", Constants.ヤマモト);
                Console.WriteLine("バカウケだった。");
                Console.WriteLine("「お礼に{0}をあげよう」", Util.ステージ衣装.Name);
                Util.TakeItem(Util.ステージ衣装);
                return false;
            }
            if (command.Verb == "sing"
                && command.Object == Constants.ムガンダ
                && State.OnlyOne.Songs.Contains(Constants.ムガンダ)
)
            {
                Console.WriteLine("僕は{0}を熱唱した。", Constants.ムガンダ);
                Console.WriteLine("バカウケだった。");
                Console.WriteLine("「お礼に{{0}をあげよう」", Util.体操着.Name);
                Util.TakeItem(Util.体操着);
                return false;
            }
            if (command.Verb == "sing"
                && command.Object == Constants.マコ
                && State.OnlyOne.Songs.Contains(Constants.マコ)
)
            {
                Console.WriteLine("僕は{0}を熱唱した。", Constants.マコ);
                Console.WriteLine("バカウケだった。");
                Console.WriteLine("「お礼に{0}をあげよう」", Util.旧型のスクール水着.Name);
                Util.TakeItem(Util.旧型のスクール水着);
                return false;
            }
            return base.CommandAction(command);
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public 元ア好き編集部Place() : base("元ア好き編集部", "元ア好き編集部") { }
    }
    /// <summary>
    /// カラオケ店
    /// </summary>
    public class カラオケ店Place : SubPlace
    {
        /// <summary>
        /// コマンドのアクション
        /// </summary>
        /// <param name="command">コマンド</param>
        /// <returns>trueを返すとゲーム終了</returns>
        public override bool CommandAction(CommandInfo command)
        {
            if (command.Verb == "go" && command.Object == "west")
            {
                Console.WriteLine("僕はドリフターズの{0}を熱唱した。", Constants.ゴーウエスト);
                Console.WriteLine("誰も誉めてくれなかった。f");
                Util.RememberSong(Constants.ゴーウエスト);
                return false;
            }
            if (command.Verb == "sing" && command.Object != "")
            {
                Console.WriteLine("僕は{0}を熱唱した。", command.Object);
                Console.WriteLine("誰も誉めてくれなかった。");
                Util.RememberSong(command.Object);
                return false;
            }
            return base.CommandAction(command);
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public カラオケ店Place() : base("カラオケ店") { }
    }
}
