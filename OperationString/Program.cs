using System;
using System.Text;

namespace OperationString
{
    class MainClass
    {
        static void Main() 
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (String.Compare(input1, input2, true) == 0)
                Console.WriteLine("入力された文字列は等しいです");

            int resultNum = 0;
            int.TryParse(input1, out resultNum);
            var strNum = resultNum.ToString("N0");
            Console.WriteLine(strNum);

            Exercise5_3();
        }

        private static void Exercise5_3()
        {
            string sampleStr = "Jackdaws love my big sphinx of quartz";

            Console.WriteLine((sampleStr.Split(" ").Count() - 1).ToString()) ;

            var stringBuilder = new StringBuilder(sampleStr);
            stringBuilder.Replace("big", "small");
            Console.WriteLine(stringBuilder.ToString());

            var words = sampleStr.Split(" ");

            int count = words.Length + 1;

            var lessThan4Words = words.Where(word => word.Length <= 4);
            lessThan4Words.ToList().ForEach(word => Console.WriteLine(word));

            stringBuilder = new StringBuilder();
            for(int i = 0; i < words.Length; i++)
            {
                stringBuilder.Append(words[i]);
                if (i != words.Length - 1)
                    stringBuilder.Append(" ");
            }
            Console.WriteLine(stringBuilder.ToString());

        }
    }
}