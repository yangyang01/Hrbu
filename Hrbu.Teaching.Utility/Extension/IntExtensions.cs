using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrbu.Teaching.Utility
{
    public static class IntExtensions
    {
        public static string IntToString(this int? obj)
        {
            if (obj.HasValue)
            {
                return obj.Value.ToString();
            }
            return string.Empty;
        }

        public static string IntToString(this int obj)
        {
            return obj.ToString();
        }
    }
}
