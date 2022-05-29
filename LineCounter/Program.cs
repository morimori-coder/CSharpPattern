using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using ClassLibraryTextOperation;

namespace LineCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextProcessor.Run<LineCounterProcessor>(args[0]);

            TextProcessor.Run<DoubleCharacterConverter>(args[0]);
        }
    }

    class LineCounterProcessor : TextProcessor
    {
        private int _count;

        protected override void Initialize(string fname)
        {
            _count = 0;
        }

        protected override void Execute(string line)
        {
            _count++;
        }

        protected override void Terminate()
        {
            Console.WriteLine("{0}行", _count);
        }
    }

    class DoubleCharacterConverter : TextProcessor
    {
        private Regex re = new Regex("[０-９]+");

        protected override void Execute(string line)
        {
            string output = re.Replace(line, p => ((char)(p.Value[0] - '０' + '0')).ToString());
            Console.WriteLine(output);
        }
    }
}