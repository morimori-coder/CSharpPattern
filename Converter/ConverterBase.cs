namespace ConverterSample
{
    public abstract class ConverterBase
    {
        public abstract bool IsMyUnit(string name);

        // メートルとの比率（この比率をかけるとメートルに変換できる）
        protected abstract double Ratio { get; }

        // 距離の単位（たとえばメートル、フィートなど）
        public abstract string UnitName { get; }

        // メートルからの変換
        public double FromMeter(double meter)
        {
            return meter / Ratio;
        }

        // メートルへの変換
        public double ToMeter(double feet)
        {
            return feet * Ratio;
        }
    }
}