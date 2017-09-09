using System.IO;
using System.Xml;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Sangubashi
{
    /// <summary>
    /// 変化する情報を扱う
    /// </summary>
    [DataContract]
    public class State
    {
        /// <summary>
        /// 現在の着衣。初期値は普段着
        /// </summary>
        [DataMember]
        public string WearingitemName = "普段着";
        /// <summary>
        /// 名前では無くItemオブジェクトを得るためのラッパ
        /// </summary>
        public Item Wearingitem
        {
            get
            {
                return Util.AllItems.FirstOrDefault(c => c.Name == WearingitemName);
            }
        }
        /// <summary>
        /// 現在の居場所。初期値は参宮箸駅
        /// </summary>
        [DataMember]
        public string CurrentPlaceId = "参宮箸駅";
        /// <summary>
        /// 名前では無くPlaceオブジェクトを得るためのラッパ
        /// </summary>
        public Place CurrentPlace
        {
            get
            {
                return Util.AllPlaces.FirstOrDefault(c => c.Id == CurrentPlaceId);
            }
        }
        /// <summary>
        /// 持ち物一覧
        /// </summary>
        [DataMember]
        public List<string> Inventory = new List<string>();
        /// <summary>
        /// 持ち歌一覧
        /// </summary>
        [DataMember]
        public List<string> Songs = new List<string>();
        /// <summary>
        /// 唯一のStateオブジェクト
        /// </summary>
        public static State OnlyOne = new State();
        /// <summary>
        /// ロードする
        /// </summary>
        /// <param name="filename">ファイル名</param>
        public static void Load(string filename)
        {
            var ds = new DataContractSerializer(typeof(State));
            if (!File.Exists(filename))
            {
                System.Console.WriteLine("{0}は見つかりません。", filename);
                return;
            }
            using (TextReader sw = File.OpenText(filename))
            {
                using (var xw = XmlReader.Create(sw))
                {
                    OnlyOne = (State)ds.ReadObject(xw, false);
                }
            }
        }
        /// <summary>
        /// セーブする
        /// </summary>
        /// <param name="filename">ファイル名</param>
        public static void Save(string filename)
        {
            var ds = new DataContractSerializer(typeof(State));
            using (TextWriter sw = File.CreateText(filename))
            {
                using (var xw = XmlWriter.Create(sw))
                {
                    ds.WriteObject(xw, OnlyOne);
                }
            }
        }
    }
}
