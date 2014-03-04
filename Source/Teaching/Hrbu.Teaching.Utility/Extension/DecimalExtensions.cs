
namespace Hrbu.Teaching.Utility
{
    public static class DecimalExtensions
    {
        public static decimal Round(this decimal? d, int decimals)
        {
            if (d.HasValue)
            {
                return decimal.Round(d.Value, decimals);
            }
            return 0.00m;
        }
        public static decimal Round(this decimal d, int decimals)
        {
            return decimal.Round(d, decimals);
        }

        public static string DecimalToString(this decimal? obj, string format)
        {
            if (obj != null)
            {
                return obj.Value.ToString(format);
            }
            return "0";
        }
    }
}
