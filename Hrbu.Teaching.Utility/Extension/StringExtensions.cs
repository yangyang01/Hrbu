using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Hrbu.Teaching.Utility
{
    public static class StringExtensions
    {
        internal const string TRUE = "TRUE";
        internal const string FALSE = "FALSE";
        internal const char TRIM_CHAR = '\\';
        internal const string SLASH = "/";
        internal const string BACKSLASH = "\\";

        public static bool ToBoolean(this string trueOrFalse)
        {
            var ret = false;
            if (string.IsNullOrEmpty(trueOrFalse) == false)
            {
                ret = trueOrFalse.Trim().EqualsOrdinalIgnoreCase(TRUE);
            }

            return ret;
        }

        public static double ToDouble(this string doubleString)
        {
            double dValue = 0.0;
            double.TryParse(doubleString, out dValue);
            return dValue;
        }

        public static bool EqualsOrdinalIgnoreCase(this string A, string B)
        {
            return string.Equals(A, B, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// yyyyMMddHHmmss
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime? ToLongDateTimeFormat(this String str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            else
            {
                return DateTime.ParseExact(str, "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture);
            }
        }

        /// <summary>
        /// yyyy-MM-dd HH:mm
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime? ToMiddleDateTimeFormat(this String str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            else
            {
                return DateTime.ParseExact(str, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.CurrentCulture);
            }
        }

        public static DateTime? ToDateTime(this string obj, string format = CommonString.TimeFormat)
        {
            if (!string.IsNullOrEmpty(obj))
            {
                DateTime time = new DateTime();
                if (DateTime.TryParseExact(obj, format, null, DateTimeStyles.None, out time))
                    return time;
                return null;
            }
            return null;
        }

        public static DateTime? ToFormalDateTime(this string obj)
        {
            if (!string.IsNullOrEmpty(obj))
            {
                DateTime time = new DateTime();
                if (DateTime.TryParse(obj, null, DateTimeStyles.None, out time))
                    return time;
                return null;
            }
            return null;
        }

        public static string ToStandardDateTime(this DateTime obj, string format)
        {
            if (format == null)
                format = CommonString.TimeFormat;
            return obj.ToString(format);
        }

        public static String ToMinuteSecond(this String str)
        {
            var timeString = string.Empty;

            if (string.IsNullOrWhiteSpace(str) == false)
            {
                var timeSpan = new TimeSpan(0, 0, int.Parse(str));

                if (timeSpan.Hours < 1) timeString = timeSpan.ToString().Remove(0, 3);
                else timeString = timeSpan.ToString();
            }

            return timeString;
        }

        public static int ToInt(this string strValue)
        {
            int iValue = 0;
            int.TryParse(strValue, out iValue);
            return iValue;
        }

        public static Nullable<int> ToNullableInt(this string obj)
        {
            if (string.IsNullOrWhiteSpace(obj)) return null;
            return obj.ToInt();
        }

        public static bool ToBool(this string obj)
        {
            var ret = false;
            bool.TryParse(obj, out ret);
            return ret;
        }

        public static Nullable<bool> ToNullableBool(this string obj)
        {
            if (string.IsNullOrWhiteSpace(obj)) return null;
            return obj.ToBool();
        }

        public static float ToFloat(this string obj)
        {
            if (string.IsNullOrEmpty(obj)) return 0.0f;
            float result = 0.0f;
            float.TryParse(obj, out result);
            return result;
        }

        public static Nullable<float> ToNullableFloat(this string obj)
        {
            if (string.IsNullOrWhiteSpace(obj)) return null;
            return obj.ToFloat();
        }

        public static decimal ToDecimal(this string obj)
        {
            if (string.IsNullOrEmpty(obj)) return 0;
            decimal result = 0;
            Decimal.TryParse(obj, out result);
            return result;
        }

        public static Nullable<decimal> ToNullableDecimal(this string obj)
        {
            if (string.IsNullOrWhiteSpace(obj)) return null;
            return obj.ToDecimal();
        }

        public static long ToLong(this string obj)
        {
            if (string.IsNullOrEmpty(obj))
                return 0;
            long result = 0;
            long.TryParse(obj, out result);
            return result;
        }

        public static Nullable<long> ToNullableLong(this string obj)
        {
            if (string.IsNullOrWhiteSpace(obj)) return null;
            return obj.ToLong();
        }

        public static string CombineCurrentAppDomainPath(this String path)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
        }

        public static string ReplaceWhiteSpacesWithOneSpace(this string strValue)
        {
            Regex r = new Regex(@"\s+");

            return r.Replace(strValue, " ");
        }

        public static string SubStringBySDBC(this string strData, int startindex, int length, int codepage = 0)
        {
            string strRtn = string.Empty;
            byte[] arybytData = Encoding.GetEncoding(codepage).GetBytes(strData);
            byte[] arybytTemp = new byte[length];
            Array.Copy(arybytData, startindex, arybytTemp, 0, length);
            strRtn = Encoding.GetEncoding(codepage).GetString(arybytTemp, 0, length);
            if (Encoding.GetEncoding(codepage).GetByteCount(strRtn) > length)
            {
                strRtn = strRtn.Substring(0, strRtn.Length - 1); ;
            }
            return strRtn;
        }

        public static int GetLengthByBytes(this string strValue, int codepage = 0)
        {
            int iRtn = 0;
            if (string.IsNullOrEmpty(strValue) == false)
                iRtn = Encoding.GetEncoding(codepage).GetByteCount(strValue);
            return iRtn;
        }

        public static string NullToString(this object obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            else
            {
                return obj.ToString();
            }
        }

        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static List<int> ToListInt(this string str, char separator)
        {
            string[] list = str.Split(separator);

            List<int> ret = new List<int>();

            foreach (var strint in list)
            {
                int int_temp = 0;
                if (int.TryParse(strint, out int_temp))
                    ret.Add(int_temp);
            }

            return ret;
        }
    }
}
