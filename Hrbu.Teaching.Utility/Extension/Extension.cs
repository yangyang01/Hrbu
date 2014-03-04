using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Hrbu.Teaching.Utility
{
    public static class Extension
    {
        public static int GetColumnIndex(this GridView grid, string name)
        {
            foreach (DataControlField col in grid.Columns)
            {
                if (col.HeaderText.ToLower().Trim() == name.ToLower().Trim())
                {
                    return grid.Columns.IndexOf(col);
                }
            }

            return -1;
        }

        public static DataControlField GetColumn(this GridView grid, string name)
        {
            foreach (DataControlField col in grid.Columns)
            {
                if (col.HeaderText.ToLower().Trim() == name.ToLower().Trim())
                {
                    return grid.Columns[grid.Columns.IndexOf(col)];
                }
            }
            return null;
        }

        //public static string IntToString(this int? obj)
        //{
        //    if (obj != null)
        //    {
        //        return obj.Value.ToString();
        //    }
        //    return "0";
        //}

        //public static string DecimalToString(this decimal? obj, string format)
        //{
        //    if (obj != null)
        //    {
        //        return obj.Value.ToString(format);
        //    }
        //    return "0";
        //}

        //public static decimal ToDecimal(this string obj)
        //{
        //    if (string.IsNullOrEmpty(obj)) return 0;
        //    else return Decimal.Parse(obj);
        //}

        //public static long ToLong(this string obj)
        //{
        //    if (string.IsNullOrEmpty(obj))
        //        return 0;
        //    return long.Parse(obj);
        //}

        //public static int ToInt(this string obj)
        //{
        //    if (string.IsNullOrEmpty(obj)) return 0;
        //    else return Int32.Parse(obj);
        //}

        public static string ObjectToString(this object obj)
        {
            if (obj == null) return "";
            return obj.ToString();
        }

        public static bool ObjectToBool(this object obj)
        {
            if (obj == null) return false;
            var ret = false;
            bool.TryParse(obj.ToString(), out ret);
            return ret;
        }
        //public static bool ToBool(this string obj)
        //{
        //    var ret = false;
        //    bool.TryParse(obj, out ret);
        //    return ret;
        //}

        //public static float ToFloat(this string obj)
        //{
        //    if (string.IsNullOrEmpty(obj)) return 0.0f;
        //    else return Convert.ToSingle(obj);
        //}

        //public static DateTime? ToDateTime(this string obj, string format = CommonString.TimeFormat)
        //{
        //    if (!string.IsNullOrEmpty(obj))
        //    {
        //        DateTime time = new DateTime();
        //        if (DateTime.TryParseExact(obj, format, null, DateTimeStyles.None, out time))
        //            return time;
        //        return null;
        //    }
        //    return null;
        //}

        //public static string ToStandardDateTime(this DateTime obj, string format)
        //{
        //    if (format == null)
        //        format = CommonString.TimeFormat;
        //    return obj.ToString(format);
        //}

        //public static bool EqualIgnoreCase(this string obj, string input)
        //{
        //    if (obj == null) return false;
        //    return obj.Equals(input, StringComparison.OrdinalIgnoreCase);
        //}

        //public static bool IsNullOrEmpty(this string obj)
        //{
        //    if (obj == null || obj == string.Empty)
        //        return true;
        //    return false;
        //}

        /// <summary>
        /// 查看model里面的Required字段是否全部不为NULL
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="checkNoRequired">是否通过检查非必填字段来判定model是否完善</param>
        /// <returns></returns>
        //public static bool RequiredIsComplete<T>(this T model)
        //{
        //    return model.RequiredIsComplete<T>(typeof(RequiredAttribute));
        //}

        //public static bool RequiredIsCompleteInHotelEntry<T>(this T model)
        //{
        //    return model.RequiredIsComplete(typeof(HotelRequiredAttribute));
        //}

        public static bool RequiredIsComplete<T>(this T model, Type attributeType)
        {
            if (model != null)
            {
                var prop = model.GetType().GetProperties();

                var checkProp = prop.Where(x => Attribute.IsDefined(x, attributeType, false)).ToArray();

                foreach (var _p in checkProp)
                {
                    var val = _p.GetValue(model, null);

                    if (val == null)
                    {
                        return false;
                    }
                    else
                    {
                        if (val.GetType().Name == "String")
                        {
                            if (string.IsNullOrWhiteSpace(val.ToString()))
                            {
                                return false;
                            }
                        }
                    }
                }

                return true;
            }

            return false;
        }

        //public static bool IsEntryStatus(this string status, EntryStatus entryStatus)
        //{
        //    return status == ((int)entryStatus).ToString();
        //}

        //public static bool IsHrNewsStatus(this string status, HrNewsStatus newsStatus)
        //{
        //    return status == ((int)newsStatus).ToString();
        //}
        ////public static <T> ToValue(Nullable<T> obj)
        //{
        //    if (obj.HasValue)
        //        return obj.Value;
        //    return obj;
        //}
    }
}
