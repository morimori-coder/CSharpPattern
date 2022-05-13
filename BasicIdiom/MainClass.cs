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
            var yearMonth = new YearMonth(2022,2);
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
