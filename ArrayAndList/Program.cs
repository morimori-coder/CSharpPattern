

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

            var exercise6_2 = GetBooks();
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

        private static List<Book> GetBooks()
        {
            var books = new List<Book> 
            { 
                new Book { Title = "C# プログラミング の 新 常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ 式 と LINQ の 極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C# ライフ", Price = 2900, Pages = 385 }, 
                new Book { Title = "一人 で 学ぶ 並列 処理 プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズ で 覚える C# 入門", Price = 5300, Pages = 604 }, 
                new Book { Title = "私 でも 分かっ た ASP. NET MVC", Price = 3200, Pages = 453 }, 
                new Book { Title = "楽しい C# プログラミング 教室", Price = 2540, Pages = 348 }, 
            };
            return books;
        }

        private static void Exercise6_2_1(IEnumerable<Book> books)
        {
            var book = books.First(n => n.Title.Equals("ワンダフル・C# ライフ"));
            Console.WriteLine(book.Title);
            Console.WriteLine($"値段は{book.Price}円");
            Console.WriteLine($"ページ数は{book.Pages}ページ");
        }

        private static void Exercise6_2_2(IEnumerable<Book> books)
        {
            var count = books.Where(n => n.Title.Contains("C#")).Count();
            Console.WriteLine($"C#が含まれている書籍の数は{count}");
        }

        private static void Exercise6_2_3(IEnumerable<Book> books)
        {
            var sum = books.Where(n => n.Title.Contains("C#"))
                .Select(n => n.Price).Average();
            Console.WriteLine($"C#が含まれている書籍の価格の平均は{sum}円");
        }

        private static void Exercise6_2_4(IEnumerable<Book> books)
        {
            var book = books.First(n => n.Price >= 4000);
            Console.WriteLine($"4000円以上の本で最初に見つかったのは{book.Title}");
        }

        private static void Exercise6_2_5(IEnumerable<Book> books)
        {
            var pages = books.Where(n => n.Price < 4000).Max(b => b.Pages);
            Console.WriteLine(pages);
        }

        private static void Exercise6_2_6(IEnumerable<Book> books)
        {
            var orderChangeBooks = books.Where(b => b.Pages >= 400).OrderByDescending(b => b.Price);
            foreach (var book in orderChangeBooks)
                Console.WriteLine($"タイトル：{book.Title},価格{book.Price}");
        }

        private static void Exercise6_2_7(IEnumerable<Book> books)
        {
            var resultBooks = books.Where(b => b.Title.Contains("C#") && b.Pages <= 500);
            foreach (var book in resultBooks)
                Console.WriteLine(book.Title);
        }
    }
}