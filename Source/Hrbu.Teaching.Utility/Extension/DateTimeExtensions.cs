using System;
using Hrbu.Teaching.Utility;

namespace Hrbu.Teaching.Utility
{
    public static class DateTimeExtensions
    {
        internal const string DATE_FORMAT = "yyyy/MM/dd";
        internal const string DATE_FORMAT_EN = "MM/dd/yyyy";
        internal const string HOUR_MINUTE = "HH:mm";
        public const string DATE_MOUTH = "yyyy-MM";
        public const string DATE_FORMAT_CH = "yyyy-MM-dd";

        public static string DateString(this DateTime dt, string culture = "")
        {
            var format = DATE_FORMAT;
            if (!string.IsNullOrWhiteSpace(culture) && culture.EqualsOrdinalIgnoreCase(Cultures.en_us))
            {
                format = DATE_FORMAT_EN;
            }
            return dt.ToString(format);
        }

        public static string DateString(this DateTime? dt, string culture = "")
        {
            if (dt.HasValue)
            {
                return dt.Value.DateString(culture);
            }

            return string.Empty;
        }

        public static string DateFormatString(this DateTime dt, string format)
        {
            return dt.ToString(format);
        }

        public static string DateFormatString(this DateTime? dt, string format = CommonString.TimeFormat)
        {
            if (dt.HasValue)
            {
                return dt.Value.ToString(format);
            }

            return string.Empty;
        }

        public static string HourMinute(this DateTime dt)
        {
            return dt.ToString(HOUR_MINUTE);
        }

        public static string HourMinute(this DateTime? dt)
        {
            if (dt.HasValue) return dt.Value.HourMinute();

            return string.Empty;
        }

        public static string AccurateToMinite(this DateTime dt, string culture = "")
        {
            var datePart = dt.DateString(culture);
            var hourMinute = dt.HourMinute();

            return string.Format("{0} {1}", datePart, hourMinute);
        }

        public static string AccurateToMinite(this DateTime? dt, string culture = "")
        {
            if (dt.HasValue) return dt.Value.AccurateToMinite(culture);

            return string.Empty;
        }

        public static int Year(this DateTime? dt)
        {
            if (dt.HasValue)
                return dt.Value.Year;
            else return 0;
        }

        public static int Month(this DateTime? dt)
        {
            if (dt.HasValue)
                return dt.Value.Month;
            else return 0;
        }

        public static int Day(this DateTime? dt)
        {
            if (dt.HasValue)
                return dt.Value.Day;
            else return 0;
        }

        public static string ToStringFormat(this TimeSpan? time, string format)
        {
            if (time.HasValue)
            {
                return time.Value.ToString(format);
            }
            return null;
        }
    }
}
