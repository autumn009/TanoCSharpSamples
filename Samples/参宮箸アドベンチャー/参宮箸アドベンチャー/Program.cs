using System;

namespace Sangubashi
{
    class Program
    {
        static void Main(string[] args)
        {
            State.OnlyOne.Inventory.Add(Util.普段着.Name);
            State.OnlyOne.Inventory.Add(Util.ハンカチ.Name);
            State.OnlyOne.Inventory.Add(Util.ちり紙.Name);
            State.OnlyOne.Inventory.Add(Util.モノポール爆弾.Name);
            Console.WriteLine("ある日、僕のところに秘密のミッションが届いた。");
            Console.WriteLine("参宮箸駅の近くに、唱歌で有名な春の小川の姉妹曲、{0}の源流があったと言うのだ。", Constants.夏の小川);
            Console.WriteLine("僕はその場所を探し出さねばならない。");
            Console.WriteLine("僕は参宮箸駅で電車を降りた。");
            // 無限ループに入る (ループはreturnで抜け出す)
            for (; ; )
            {
                Console.Write("Command?(type 'bye' to end)>");
                var line = Console.ReadLine();
                // もし、コンソールの標準入力がファイルでそのファイルが終わったら終了する
                if (line == null) return;
                var command = Util.ParseCommandLine(line);
                // 何も入力されないときは入力を繰り返す
                if (command.Verb == "") continue;
                // 動詞がbyeのときは終了する
                if (command.Verb == "bye") return;

                bool terminate = State.OnlyOne.CurrentPlace.CommandAction(command);
                if (terminate) break;
            }
            Console.WriteLine("Type Enter key to end this program. Conguraturation!");
            Console.ReadLine();
        }
    }
}
