using System.Collections.Generic;
using System.Linq;

namespace Hrbu.Teaching.Utility
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// 判断数据源是否为Null或者为空
        /// </summary>
        /// <typeparam name="T">泛型类型</typeparam>
        /// <param name="source">数据源</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }

        /// <summary>
        /// 判断数据源是否不为空
        /// </summary>
        /// <typeparam name="T">泛型类型</typeparam>
        /// <param name="source">数据源</param>
        /// <returns></returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> source)
        {
            return source != null && source.Any();
        }
    }
}
