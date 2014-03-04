using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrbu.Teaching.Utility
{
    public interface IConfig
    {
        string ConnectionString { get; }
    }
}
