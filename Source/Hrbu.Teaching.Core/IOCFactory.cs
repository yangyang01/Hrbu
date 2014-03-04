using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hrbu.Teaching.Core;

namespace Hrbu.Teaching.Core
{
    public class IOCFactory
    {
        public static T GetInstance<T>()
        {
            return WcfClientContainer.Instance().Resolve<T>();
        }
    }
}
