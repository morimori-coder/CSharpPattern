using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationDictionary
{
    class Abbreviations
    {
        private Dictionary<string, string> _dict = new Dictionary<string, string>();

        // コンストラクタ
        public Abbreviations()
        {
            var lines = File.ReadAllLines("Abbreviations.txt");
            _dict = lines.Select(line => line.Split('=')).ToDictionary(x => x[0], x => x[1]);
        }

        // 要素の追加
        public void Add(string abbr, string jampanese)
        {
            _dict[abbr] = jampanese;
        }

        // インデクサ
        public string this[string abbr]
        {
            get
            { return _dict.ContainsKey(abbr) ? _dict[abbr] : null;}
        }

        // 日本語から対応する省略後を取り出す
        public string ToAbbreviation(string japanese)
        {
            return _dict.FirstOrDefault(x => x.Value == japanese).Key;
        }

        // 日本語の位置を引数に与え、それが含まれる要素（Key,Value）を全て取り出す
        public IEnumerable<KeyValuePair<string,string>> FindAll(string substring)
        {
            foreach(var item in _dict)
            {
                if (item.Value.Contains(substring))
                    yield return item;
            }
        }
    }
}
