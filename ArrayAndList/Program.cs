namespace ArrayAndList
{
    class MainClass
    {
        public static void Main()
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            // 最大値を表示
            CalcMax(numbers);

            // 最後から2つ目の要素を表示
            GetArrayComponent(numbers, 2);

            // それぞれの数字要素を文字列に変換
            ConvertNumToString(numbers);
        }

        static void CalcMax(int[] numArray)
        {
            var maxNum = numArray.Max();
            Console.WriteLine("問題6.1_1の答えは以下");
            Console.WriteLine(maxNum.ToString());
            Console.WriteLine();
        }

        static void GetArrayComponent(int [] numArray, int indexNum)
        {
            if (0 > (numArray.Length - indexNum)) return;

            var skip = numArray.Length - 2;
            Console.WriteLine("問題6.1_2の答えは以下");
            foreach(var n in numArray.Skip(skip))
                Console.WriteLine(n);

        }

        static void ConvertNumToString(int [] numArray) 
        {
            var strs = numArray.Select(n => n.ToString());
            foreach (var s in strs)
                Console.WriteLine(s);
        }

        static void GetTopOf3(int [] numArray)
        {
            foreach (var n in numArray.OrderBy(n => n).Take(3))
                Console.WriteLine(n);
        }

        private static void Exercise1_5(int[] numArray)
        {
            var count = numArray.Distinct().Count(n => n > 10);
            Console.WriteLine(count);
        }


    }
}