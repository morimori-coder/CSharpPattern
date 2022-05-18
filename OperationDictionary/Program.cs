namespace OperationDictionary
{
    class MainClass
    {
        public static void Main()
        {
            var sampleStr = "Cozy lummox gives smart squid who asks for job pen";


            var dict = new Dictionary<MonthDay, string>
            {
                {new MonthDay(3,5), "珊瑚の日"},
                { new MonthDay(8,4), "端の日"},
                {new MonthDay(10,3), "登山の日"},
            };

            var md = new MonthDay(8, 4);
            var s = dict[md];
            Console.WriteLine(s);

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