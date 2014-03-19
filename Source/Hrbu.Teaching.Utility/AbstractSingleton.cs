using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrbu.Teaching.Utility
{
    public abstract class AbstractSingleton<T> where T : new()
    {
        static AbstractSingleton()
        { }

        private static readonly T t = new T();

        public static T Instance
        {
            get
            {
                return t;
            }
        }
    }
}
