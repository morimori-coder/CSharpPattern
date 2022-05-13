using System;

namespace Linq 
{
    class MainClass 
    {
        static void Main()
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var result1 = numbers.Exists(n => (n % 8 == 0) || n % 9 == 0);
            Console.WriteLine($"Exits結果:{result1}");

            Console.WriteLine("$ForEach結果:");
            numbers.ForEach(n => Console.WriteLine(n / 2.0));

            Console.WriteLine("$Where結果:");
            var whereReault = numbers.Where(n => n >= 50);
            whereReault.ToList().ForEach(n => Console.WriteLine(n));


            Console.WriteLine("Select結果:");
            var selectResult = numbers.Select(n => n * 2).ToList();
            selectResult.ForEach(n => Console.WriteLine(n));


            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };
            var line = Console.ReadLine();
            var indexNum = names.FindIndex(n => n.Equals(line));
            Console.WriteLine($"index値：{indexNum}");


            var count = names.Count(n => n.Contains("o"));
            Console.WriteLine($"count値：{count}");

            Console.WriteLine($"oが含まれている都市：");
            var array = names.Where(n => n.Contains("o")).ToArray();
            array.ToList().ForEach(n => Console.WriteLine(n));

            var cityNameLength = names.Where(n => n.StartsWith("B"))
                                        .Select(n => n.Count()).ToList();

            Console.WriteLine("都市名にBが含まれている文字の文字数");
            cityNameLength.ForEach(n => Console.WriteLine(n));

            Console.ReadKey();
        }
    }
}