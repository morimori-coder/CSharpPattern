
namespace BasicIdiom
{
    class YearMonth
    {
        public int Year { get; }
        public int Month { get; }
        public bool Is21Century
        {
            get { return 2001 <= this.Year && Year <= 2100; }
        }

        public YearMonth(int year, int month)
        {
            this.Year = year;
            this.Month = month;
        }

        public YearMonth AddOneMonth(int year, int month)
        {
            year = month >= 12 ? ++year : year;
            month = month >= 12 ? 1 : ++month;
            return new YearMonth(year, month);
        }

        public override string ToString()
        {
            return $"{this.Year}年{this.Month}月";
        }

        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}