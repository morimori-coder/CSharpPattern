namespace OperationDictionary
{
    class MainClass
    {
        public static void Main()
        {
            // Abbreviationsクラスの利用例
            var abbrs = new Abbreviations();

            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            // インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names)
            {
                var fullname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}は見つかりません", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();

            // ToAbbreviationメソッドの利用例
            var japanese = "東南アジア諸国連合";
            var abbreviation = abbrs.ToAbbreviation(japanese);
            if (abbreviation == null)
                Console.WriteLine("{0}は見つかりません", japanese);
            else
                Console.WriteLine("「{0}」の略語は{1}です", japanese, abbreviation);
            Console.WriteLine();

            // FindAllメソッドの利用例
            foreach(var item in abbrs.FindAll("国際"))
            {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();

            Console.ReadKey();

            // 章末問題
            //var sampleStr = "Cozy lummox gives smart squid who asks for job pen";
            //var dict = new Dictionary<MonthDay, string>
            //{
            //    {new MonthDay(3,5), "珊瑚の日"},
            //    { new MonthDay(8,4), "端の日"},
            //    {new MonthDay(10,3), "登山の日"},
            //};

            //var md = new MonthDay(8, 4);
            //var s = dict[md];
            //Console.WriteLine(s);
        }

        private static void Exercise7_1_1(string sample)
        {
            //var countByAlphabet 
            var dic = new Dictionary<char, int>();
            foreach (var singleChar in sample)
            {
                var uc = char.ToUpper(singleChar);
                if ('A' <= uc && uc <= 'Z') 
                {
                    if (dic.ContainsKey(uc))
                        dic[uc]++;
                    else
                        dic[uc] = 1;
                }
            }
            foreach (var item in dic.OrderBy(x => x.Key))
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
        }
    }
}