using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Reflection;

namespace Sangubashi
{
    /// <summary>
    /// 解析済みの1行のコマンド情報を持つ
    /// </summary>
    public class CommandInfo
    {
        /// <summary>
        /// 動詞の情報
        /// </summary>
        public string Verb { get; set; }
        /// <summary>
        /// 目的語の情報
        /// </summary>
        public string Object { get; set; }
    }

    /// <summary>
    /// 静的な各種情報を持つ
    /// </summary>
    public class Util
    {
        private static void parseCommandLineSub(string s, StringBuilder verb, StringBuilder obj)
        {
            var p = 0;
            for (; ; )
            {
                if (p >= s.Length) return;
                if (char.IsWhiteSpace(s[p])) break;
                verb.Append(s[p++]);
            }
            for (; ; )
            {
                if (p >= s.Length) return;
                if (!char.IsWhiteSpace(s[p])) break;
                p++;
            }
            for (; ; )
            {
                if (p >= s.Length) return;
                obj.Append(s[p++]);
            }
        }
        /// <summary>
        /// コマンド1行を解析する
        /// </summary>
        /// <param name="s">コマンド行</param>
        /// <returns>解析結果</returns>
        public static CommandInfo ParseCommandLine(string s)
        {
            var verb = new StringBuilder();
            var obj = new StringBuilder();
            parseCommandLineSub(s.Trim(), verb, obj);
            return new CommandInfo()
            {
                Verb = verb.ToString(),
                Object = obj.ToString()
            };
        }
        /// <summary>
        /// 場所移動を実現する汎用メソッド
        /// 同じメッセージを出す箇所が複数あるのでまとめてある。
        /// </summary>
        /// <param name="dest">行き先</param>
        public static void Goto(Place dest)
        {
            Console.Write("僕は{0}を離れて、", State.OnlyOne.CurrentPlace.Name);
            State.OnlyOne.CurrentPlaceId = dest.Id;
            Console.WriteLine("{0}に移動した。", State.OnlyOne.CurrentPlace.Name);
        }
        /// <summary>
        /// useコマンドの処理
        /// </summary>
        /// <param name="command">コマンド</param>
        public static void UseCommand(CommandInfo command)
        {
            if (!State.OnlyOne.Inventory.Contains(command.Object))
            {
                Console.WriteLine("僕は{0}なんて持っていないぞ。", command.Object);
                return;
            }
            Util.AllItems.First(c => c.Name == command.Object).Use();
        }
        /// <summary>
        /// goコマンドの処理
        /// </summary>
        /// <param name="command">コマンド</param>
        public static void GoCommand(CommandInfo command)
        {
            switch (command.Object)
            {
                case "north":
                case "south":
                case "east":
                case "west":
                    break;
                default:
                    Console.WriteLine("{0}は理解できない方向だ。", command.Object);
                    return;
            }

            var global = State.OnlyOne.CurrentPlace as GlobalPlace;
            if (global == null)
            {
                Console.WriteLine("壁があって移動できない。まず外に出よう。");
                return;
            }

            Func<GlobalPlace> destination;
            switch (command.Object)
            {
                case "north":
                    destination = global.NorthPlace;
                    break;
                case "south":
                    destination = global.SouthPlace;
                    break;
                case "east":
                    destination = global.EastPlace;
                    break;
                default:
                    destination = global.WestPlace;
                    break;
            }
            if (destination == null || destination() == null)
            {
                Console.WriteLine("そちらには道が無い。移動できないぞ。");
                return;
            }
            Goto(destination());
        }
        /// <summary>
        /// lookコマンドの処理
        /// </summary>
        /// <param name="command">コマンド</param>
        public static void LookCommand(CommandInfo command)
        {
            Console.WriteLine("ここは{0}だ。", State.OnlyOne.CurrentPlace.Name);
            State.OnlyOne.CurrentPlace.Look();
        }
        /// <summary>
        /// exitコマンドの処理
        /// </summary>
        /// <param name="command">コマンド</param>
        public static void ExitCommand(CommandInfo command)
        {
            var sub = State.OnlyOne.CurrentPlace as SubPlace;
            if (sub == null)
            {
                Console.WriteLine("既に外に出ているぞ。");
                return;
            }
            Goto(sub.ExitPlace());
        }
        /// <summary>
        /// enterコマンドの処理
        /// </summary>
        /// <param name="command">コマンド</param>
        public static void EnterCommand(CommandInfo command)
        {
            var global = State.OnlyOne.CurrentPlace as GlobalPlace;
            if (global == null)
            {
                Console.WriteLine("既に入っているぞ。");
                return;
            }
            if (global.SubPlace == null || global.SubPlace() == null)
            {
                Console.WriteLine("入る場所は見当たらない。");
                return;
            }
            Goto(global.SubPlace());
        }
        /// <summary>
        /// enterコマンドの処理
        /// </summary>
        /// <param name="command">コマンド</param>
        public static void LoadCommand(CommandInfo command)
        {
            if (command.Object.Length == 0)
            {
                Console.WriteLine("ファイル名を指定してください。");
                return;
            }
            State.Load(command.Object);
            Console.WriteLine("ロードしました。");
        }
        /// <summary>
        /// enterコマンドの処理
        /// </summary>
        /// <param name="command">コマンド</param>
        public static void SaveCommand(CommandInfo command)
        {
            if (command.Object.Length == 0)
            {
                Console.WriteLine("ファイル名を指定してください。");
                return;
            }
            State.Save(command.Object);
            Console.WriteLine("セーブしました。");
        }
        /// <summary>
        /// 持ち物一覧
        /// </summary>
        /// <param name="command">コマンド</param>
        public static void InventoryCommand(CommandInfo command)
        {
            if (State.OnlyOne.Inventory.Count() == 0)
            {
                Console.WriteLine("持ち物は何も無い");
                return;
            }
            Console.WriteLine("現在の持ち物は以下の通りだ。");
            foreach (var item in State.OnlyOne.Inventory)
                Console.WriteLine(item);
        }

        /// <summary>
        /// 持ち歌一覧
        /// </summary>
        /// <param name="command">コマンド</param>
        public static void RepatoryCommand(CommandInfo command)
        {
            if (State.OnlyOne.Songs.Count() == 0)
            {
                Console.WriteLine("持ち歌は何も無い");
                return;
            }
            Console.WriteLine("現在の持ち歌は以下の通りだ。");
            foreach (var item in State.OnlyOne.Songs)
                Console.WriteLine(item);
        }
        /// <summary>
        /// 歌を覚える
        /// </summary>
        /// <param name="songname">歌の名前</param>
        public static void RememberSong(string songname)
        {
            if (State.OnlyOne.Songs.Contains(songname))
            {
                Console.WriteLine("僕は{0}の歌詞を既に知っている。", songname);
                return;
            }
            Console.WriteLine("僕は{0}の歌詞を覚えた。", songname);
            State.OnlyOne.Songs.Add(songname);
        }
        /// <summary>
        /// 参宮箸駅の場所オブジェクト (実行中に変化することはない)
        /// </summary>
        public static readonly GlobalPlace 参宮箸駅 = new GlobalPlace("参宮箸駅", "参宮箸駅")
        {
            NorthPlace = () => Util.山ノ手通りA,
            LookProc = () =>
            {
                Console.WriteLine("知らない男が声を掛けてきた。");
                Console.WriteLine("「そこの少年、凛々しいな」");
                Console.WriteLine("ムカッ。僕は女だぞ。");
            }
        };
        /// <summary>
        /// 山ノ手通りAの場所オブジェクト (実行中に変化することはない)
        /// </summary>
        public static readonly GlobalPlace 山ノ手通りA = new GlobalPlace("山ノ手通り", "山ノ手通りA")
        {
            NorthPlace = () => Util.山ノ手通りB,
            SouthPlace = () => Util.参宮箸駅,
            EastPlace = () => Util.拳闘博物館,
            LookProc = () =>
            {
                Console.WriteLine("知らない男が声を掛けてきた。");
                Console.WriteLine("「東に行くと拳闘博物館だぞ」");
                Console.WriteLine("僕は暴力的な行為に興味は無い。");
            }
        };
        /// <summary>
        /// 山ノ手通りBの場所オブジェクト (実行中に変化することはない)
        /// </summary>
        public static readonly GlobalPlace 山ノ手通りB = new GlobalPlace("山ノ手通り", "山ノ手通りB")
        {
            NorthPlace = () => Util.初物台駅,
            SouthPlace = () => Util.山ノ手通りA,
            EastPlace = () => Util.元ア好き編集部,
            LookProc = () =>
            {
                Console.WriteLine("知らない男が声を掛けてきた。");
                Console.WriteLine("「君はアニソンが好きか?」");
                Console.WriteLine("別に好きじゃない。");
            }
        };
        /// <summary>
        /// 初物台駅の場所オブジェクト (実行中に変化することはない)
        /// </summary>
        public static readonly GlobalPlace 初物台駅 = new GlobalPlace("初物台駅", "初物台駅")
        {
            NorthPlace = () => Util.ペラ助シティ,
            SouthPlace = () => Util.山ノ手通りB,
            LookProc = () =>
            {
                Console.WriteLine("知らない男が声を掛けてきた。");
                Console.WriteLine("「初物台駅は京玉線の駅だ。京玉線は、玉が無い女には乗れないのだ」");
                Console.WriteLine("ウソつけ。");
            }
        };
        /// <summary>
        /// ペラ助シティの場所オブジェクト (実行中に変化することはない)
        /// </summary>
        public static readonly GlobalPlace ペラ助シティ = new GlobalPlace("ペラ助シティ", "ペラ助シティ")
        {
            SouthPlace = () => Util.初物台駅,
            SubPlace = () => Util.カラオケ店,
            LookProc = () =>
            {
                Console.WriteLine("知らないオウムが声を掛けてきた。");
                Console.WriteLine("「ペラ助シティの名物はパイの店ミンナ・アラーズだペッチャ」");
                Console.WriteLine("そんな店は無かった。");
            }
        };
        /// <summary>
        /// 拳闘博物館の場所オブジェクト (実行中に変化することはない)
        /// </summary>
        public static readonly GlobalPlace 拳闘博物館 = new 拳闘博物館Place()
        {
            WestPlace = () => Util.山ノ手通りA,
            LookProc = () =>
            {
                Console.WriteLine("知らない男が声を掛けてきた。");
                Console.WriteLine("「そこの君、拳を合わせて身体と身体で語り合わないか?」");
                Console.WriteLine("結構です。");
            }
        };
        /// <summary>
        /// 元ア好き編集部の場所オブジェクト (実行中に変化することはない)
        /// </summary>
        public static readonly GlobalPlace 元ア好き編集部 = new 元ア好き編集部Place()
        {
            WestPlace = () => Util.山ノ手通りB,
            LookProc = () =>
            {
                Console.WriteLine("マニアが寄ってきた。");
                Console.WriteLine("「ここは元アニソン好き雑紙編集部の慣れの果て。略して元ア好き編集部」");
                string[] songs = { Constants.ヤマモト, Constants.ムガンダ, Constants.マコ };
                foreach (var song in songs)
                {
                    Console.WriteLine("「{0}歌って!　{0}歌って!」", song);
                }
            }
        };
        /// <summary>
        /// カラオケ店の場所オブジェクト (実行中に変化することはない)
        /// </summary>
        public static readonly SubPlace カラオケ店 = new カラオケ店Place()
        {
            ExitPlace = () => Util.ペラ助シティ,
            LookProc = () =>
            {
                Console.WriteLine("ここで歌うと歌詞を覚えられそうな気がした。");
            }
        };
        /// <summary>
        /// アイテムを入手する
        /// </summary>
        /// <param name="item">入手するアイテム</param>
        public static void TakeItem(Item item)
        {
            if (State.OnlyOne.Inventory.Contains(item.Name))
            {
                Console.WriteLine("{0}は既に持っている。", item.Name);
                return;
            }
            Console.WriteLine("{0}をもらった。", item.Name);
            State.OnlyOne.Inventory.Add(item.Name);
        }
        private static int hintcount = 0;
        /// <summary>
        /// ヒントを提供する　(20回で一周する)
        /// </summary>
        public static void Hints()
        {
            switch ((hintcount++) % 20)
            {
                case 2:
                    Console.WriteLine("取りあえず、'look' + Entereキーと打つといいらしいぞ。");
                    break;
                case 5:
                    Console.WriteLine("go north, go south, go east, go westで4方向に移動できるらしいぞ。");
                    break;
                case 8:
                    Console.WriteLine("enterで入れる店もあるらしい。入った店はexitで出る。");
                    break;
                case 11:
                    Console.WriteLine("'use アイテム名'でアイテムを使用できるらしいぞ。");
                    break;
                case 15:
                    Console.WriteLine("所有しているアイテム名一覧はInventoryらしいぞ。");
                    break;
                case 16:
                    Console.WriteLine("'sing 歌の名前'で歌えるらしいぞ。");
                    break;
                case 18:
                    Console.WriteLine("カラオケボックスで歌うと、持ち歌になるらしいぞ。");
                    break;
                case 19:
                    Console.WriteLine("持ち歌一覧はRepartoryらしいぞ。");
                    break;
                default:
                    Console.WriteLine("僕にどうしろっていうの?");
                    break;
            }
        }

        /// <summary>
        /// 正解の推理を邪魔する煙幕として使う意味の無いアイテム
        /// </summary>
        public static readonly Item ハンカチ = new Item("ハンカチ");
        /// <summary>
        /// 正解の推理を邪魔する煙幕として使う意味の無いアイテム
        /// </summary>
        public static readonly Item ちり紙 = new Item("ちり紙");
        /// <summary>
        /// 正解の推理を邪魔する煙幕として使う意味の無いアイテム
        /// </summary>
        public static readonly Item モノポール爆弾 = new Item("モノポール爆弾")
        {
            UseProc = () =>
            {
                Console.WriteLine("僕は編集部の破壊工作に派遣されたわけではない。");
                Console.WriteLine("今回の任務に、こんなものは要らない。");
            }
        };
        /// <summary>
        /// 旧型のスクール水着　(ソースを見れば分かるが説明コメントが無いと警告が出てしまう
        /// </summary>
        public static readonly Item 旧型のスクール水着 = new Wareitem("旧型のスクール水着");
        /// <summary>
        /// ステージ衣装　(ソースを見れば分かるが説明コメントが無いと警告が出てしまう
        /// </summary>
        public static readonly Item ステージ衣装 = new Wareitem("ステージ衣装");
        /// <summary>
        /// 体操着　(ソースを見れば分かるが説明コメントが無いと警告が出てしまう
        /// </summary>
        public static readonly Item 体操着 = new Wareitem("体操着");
        /// <summary>
        /// 普段着　(ソースを見れば分かるが説明コメントが無いと警告が出てしまう
        /// </summary>
        public static readonly Item 普段着 = new Wareitem("普段着");
        /// <summary>
        /// 全てのアイテムを持つ配列を保持する
        /// </summary>
        public static readonly Item[] AllItems;
        /// <summary>
        /// 全ての場所を持つ配列を保持する
        /// </summary>
        public static readonly Place[] AllPlaces;
        private static T[] autoCollect<T>()
        {
            var list = new List<T>();
            foreach (var item in typeof(Util).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                if (item.FieldType == typeof(T) || item.FieldType.IsSubclassOf(typeof(T))) list.Add((T)item.GetValue(null));
            }
            return list.ToArray();
        }
        /// <summary>
        /// コンストラクタ。アイテム一覧を作成する
        /// </summary>
        static Util()
        {
            AllItems = autoCollect<Item>();
            AllPlaces = autoCollect<Place>();
        }
    }
}
