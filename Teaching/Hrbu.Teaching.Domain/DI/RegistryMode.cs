using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrbu.Teaching.Domain
{
    [Flags]
    public enum RegistryMode
    {
        None,

        Debug = 1,

        Release = 2,

        Live = 4
    }
}
