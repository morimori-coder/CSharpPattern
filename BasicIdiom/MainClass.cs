using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicIdiom
{
    public class MainClass
    {
        public static void Main() 
        {
            YearMonth[] yearMonths = new YearMonth[5];
            yearMonths[0] = new YearMonth(1001, 1);
            yearMonths[1] = new YearMonth(1002, 2);
            yearMonths[2] = new YearMonth(1003, 3);
            yearMonths[3] = new YearMonth(1004, 4);
            yearMonths[4] = new YearMonth(1005, 12);

            yearMonths.ToList().ForEach(n => Console.WriteLine(n));

            var firstYearMonth = GetFirst21CenturyInArray(yearMonths);
            var firstYear = firstYearMonth == null ? "21世紀のデータはありません。" : $"{firstYearMonth.Year.ToString()}年";
            Console.WriteLine(firstYear);

            var newYearMonths = yearMonths.OrderBy(y => y.Year).Select(y => y.AddOneMonth(y.Year, y.Month)).ToList();
            newYearMonths.ForEach(n => Console.WriteLine(n));

            Console.ReadKey();
        }

        static private YearMonth GetFirst21CenturyInArray(IEnumerable<YearMonth> yearMonths)
        {
            YearMonth result = null;
            foreach (var y in yearMonths)
            {
                if (y.Is21Century)
                {
                    result = y;
                    break;
                }
            }
            return result;
        }

        static void CallSwap()
        {
            //string a = "A";
            //string b = "B";
            int a = 1;
            int b = 2;
            YearMonth.Swap<int>(ref a, ref b);
        }
    }
}
